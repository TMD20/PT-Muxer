// ***********************************************************************
// Copyright (c) 2010 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

#if MONO

using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework.Api;

namespace NUnit.Framework.Internal.Commands
{
    public class FlakyTestRetriesDecorator : ICommandDecorator
    {
        #region ICommandDecorator Members

        CommandStage ICommandDecorator.Stage
        {
            get { return CommandStage.AboveSetUpTearDown; }
        }

        int ICommandDecorator.Priority
        {
            get { return 0; }
        }

        TestCommand ICommandDecorator.Decorate(TestCommand command)
        {
            return new FlakyTestRetriesCommand(command);
        }

        #endregion
    }

    public class FlakyTestRetriesCommand : DelegatingTestCommand
    {
        int retries = 0;
        const int MASS_FAIL_SAFEGUARD = 10;

        private static int globalTotalRetries = 0;

        public FlakyTestRetriesCommand(TestCommand innerCommand)
            : base(innerCommand)
        {
            string retriesEnv = Environment.GetEnvironmentVariable ("MONO_FLAKY_TEST_RETRIES");
            Int32.TryParse (retriesEnv, out retries);
        }

        public override TestResult Execute(TestExecutionContext context)
        {
            // regular test execution
            context.CurrentResult = innerCommand.Execute(context);

            if (retries == 0 ||
                context.CurrentResult.ResultState.Status == TestStatus.Passed ||
                context.CurrentResult.ResultState.Status == TestStatus.Skipped ||
                context.CurrentResult.ResultState.Status == TestStatus.Inconclusive)
                return context.CurrentResult;

            // skip retries after a certain number to avoid retrying mass failures
            if (globalTotalRetries++ >= MASS_FAIL_SAFEGUARD)
            {
                Test.Properties.Set("FlakyTestRetries.MassFailSafeguard", true);
                return context.CurrentResult;
            }

            // regular test execution resulted in a failed test, start doing retries
            var passedTestResults = new List<TestResult>();
            var failedTestResults = new List<TestResult>();

            for (int i = 0; i < retries; i++)
            {
                Thread.Sleep (1000); // give the test some time to close files, sockets etc

                var testResult = innerCommand.Execute(context);

                if (testResult.ResultState.Status == TestStatus.Passed)
                    passedTestResults.Add(testResult);
                else
                    failedTestResults.Add(testResult);
            }

            // overall result is based on majority of results,
            // we return the first passed/failed result here and log stats about the rest
            var overallResult = passedTestResults.Count > failedTestResults.Count;
            context.CurrentResult = overallResult ? passedTestResults[0] : failedTestResults[0];

            Test.Properties.Set("FlakyTestRetries.Result", overallResult ? "PASS" : "FAIL");
            Test.Properties.Set("FlakyTestRetries.PassCount", passedTestResults.Count);
            Test.Properties.Set("FlakyTestRetries.FailCount", failedTestResults.Count);

            return context.CurrentResult;
        }
    }
}

#endif
