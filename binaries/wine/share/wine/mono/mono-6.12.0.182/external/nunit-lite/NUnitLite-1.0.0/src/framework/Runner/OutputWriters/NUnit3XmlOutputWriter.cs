// ***********************************************************************
// Copyright (c) 2011 Charlie Poole
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

using System;
using System.IO;
using System.Reflection;
using System.Xml;
using NUnit.Framework.Api;
using NUnit.Framework.Internal;

namespace NUnitLite.Runner
{
    /// <summary>
    /// NUnit3XmlOutputWriter is responsible for writing the results
    /// of a test to a file in NUnit 3.0 format.
    /// </summary>
    public class NUnit3XmlOutputWriter : OutputWriter
    {
        private DateTime runStartTime;
        private XmlWriter xmlWriter;

        public NUnit3XmlOutputWriter(DateTime runStartTime)
        {
            this.runStartTime = runStartTime;
        }
        /// <summary>
        /// Writes the test result to the specified TextWriter
        /// </summary>
        /// <param name="result">The result to be written to a file</param>
        /// <param name="writer">A TextWriter to which the result is written</param>
        public override void WriteResultFile(ITestResult result, TextWriter writer)
        {
            // NOTE: Under .NET 1.1, XmlTextWriter does not implement IDisposable,
            // but does implement Close(). Hence we cannot use a 'using' clause.
#if CLR_2_0 || CLR_4_0
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter xmlWriter = XmlWriter.Create(writer, settings);
#else
            XmlTextWriter xmlWriter = new XmlTextWriter(writer);
            xmlWriter.Formatting = Formatting.Indented;
#endif

            try
            {
                WriteXmlOutput(result, xmlWriter);
            }
            finally
            {
                xmlWriter.Close();
            }
        }

        private void WriteXmlOutput(ITestResult result, XmlWriter xmlWriter)
        {
            this.xmlWriter = xmlWriter;

            InitializeXmlFile(result);
            WriteResultElement(result);
            TerminateXmlFile();
        }

        private void InitializeXmlFile(ITestResult result)
        {
            xmlWriter.WriteStartDocument(false);

            // In order to match the format used by NUnit 3.0, we
            // wrap the entire result from the framework in a 
            // <test-run> element.
            xmlWriter.WriteStartElement("test-run");

            xmlWriter.WriteAttributeString("id", "2"); // TODO: Should not be hard-coded
            xmlWriter.WriteAttributeString("name", result.Name);
            xmlWriter.WriteAttributeString("fullname", result.FullName);
            xmlWriter.WriteAttributeString("testcasecount", result.Test.TestCaseCount.ToString());

            xmlWriter.WriteAttributeString("result", result.ResultState.Status.ToString());
            if (result.ResultState.Label != string.Empty) // && result.ResultState.Label != ResultState.Status.ToString())
                xmlWriter.WriteAttributeString("label", result.ResultState.Label);

            xmlWriter.WriteAttributeString("time", result.Duration.ToString());

            xmlWriter.WriteAttributeString("total", (result.PassCount + result.FailCount + result.SkipCount + result.InconclusiveCount).ToString());
            xmlWriter.WriteAttributeString("passed", result.PassCount.ToString());
            xmlWriter.WriteAttributeString("failed", result.FailCount.ToString());
            xmlWriter.WriteAttributeString("inconclusive", result.InconclusiveCount.ToString());
            xmlWriter.WriteAttributeString("skipped", result.SkipCount.ToString());
            xmlWriter.WriteAttributeString("asserts", result.AssertCount.ToString());

            xmlWriter.WriteAttributeString("run-date", XmlConvert.ToString(runStartTime, "yyyy-MM-dd"));
            xmlWriter.WriteAttributeString("start-time", XmlConvert.ToString(runStartTime, "HH:mm:ss"));

            xmlWriter.WriteAttributeString("random-seed", Randomizer.InitialSeed.ToString());

            WriteEnvironmentElement();
        }

        private void WriteEnvironmentElement()
        {
            xmlWriter.WriteStartElement("environment");

            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = AssemblyHelper.GetAssemblyName(assembly);
            xmlWriter.WriteAttributeString("nunit-version", assemblyName.Version.ToString());

            xmlWriter.WriteAttributeString("clr-version", Environment.Version.ToString());
            xmlWriter.WriteAttributeString("os-version", Environment.OSVersion.ToString());
            xmlWriter.WriteAttributeString("platform", Environment.OSVersion.Platform.ToString());
#if !NETCF
            xmlWriter.WriteAttributeString("cwd", Environment.CurrentDirectory);
#if !SILVERLIGHT
            xmlWriter.WriteAttributeString("machine-name", Environment.MachineName);
            xmlWriter.WriteAttributeString("user", Environment.UserName);
            xmlWriter.WriteAttributeString("user-domain", Environment.UserDomainName);
#endif
#endif
            xmlWriter.WriteAttributeString("culture", System.Globalization.CultureInfo.CurrentCulture.ToString());
            xmlWriter.WriteAttributeString("uiculture", System.Globalization.CultureInfo.CurrentUICulture.ToString());

            xmlWriter.WriteEndElement();
        }

        private void WriteTestSuiteAttirbutes(ITestResult result)
        {
            var testSuite = result.Test as TestSuite;
            xmlWriter.WriteAttributeString("type", testSuite.TestType);
            xmlWriter.WriteAttributeString("id", testSuite.Id.ToString ());
            xmlWriter.WriteAttributeString("name", testSuite.Name);
            xmlWriter.WriteAttributeString("fullname", testSuite.FullName);
            xmlWriter.WriteAttributeString("testcasecount", testSuite.TestCaseCount.ToString ());
            xmlWriter.WriteAttributeString("result", result.ResultState.Status.ToString ());
            xmlWriter.WriteAttributeString("time", result.Duration.ToString ());
            xmlWriter.WriteAttributeString("total", (result.PassCount + result.FailCount + result.SkipCount + result.InconclusiveCount).ToString ());
            xmlWriter.WriteAttributeString("passed", result.PassCount.ToString ());
            xmlWriter.WriteAttributeString("failed", result.FailCount.ToString ());
            xmlWriter.WriteAttributeString("inconclusive", result.InconclusiveCount.ToString ());
            xmlWriter.WriteAttributeString("skipped", result.SkipCount.ToString ());
            xmlWriter.WriteAttributeString("asserts", result.AssertCount.ToString ());
        }

        private void WriteProperties(ITestResult result)
        {
            var properties = result.Test.Properties;
            int nprops = 0;

            foreach (string key in properties.Keys) {
                foreach (object prop in properties [key]) {
                    if (nprops++ == 0)
                        xmlWriter.WriteStartElement ("properties");

                    xmlWriter.WriteStartElement ("property");
                    xmlWriter.WriteAttributeString ("name", key);
                    xmlWriter.WriteAttributeString ("value", prop.ToString ());
                    xmlWriter.WriteEndElement ();
                }
            }

            if (nprops > 0)
                xmlWriter.WriteEndElement (); // properties

        }
        
        private void WriteResultElement(ITestResult result)
        {
            if (result.Test is TestSuite) { // all test-suites are similar
                xmlWriter.WriteStartElement("test-suite");
                WriteTestSuiteAttirbutes(result);

                WriteProperties(result);
                switch(result.ResultState.Status) {
                case TestStatus.Skipped:
                case TestStatus.Inconclusive:
                        WriteReasonElement(result.Message);
                        break;
                case TestStatus.Failed:
                        WriteFailureElement(result.Message, result.StackTrace, result.ExceptionType ?? "UnknownException");
                        break;
                }

                if (result.FailCount > 0) {
                        xmlWriter.WriteStartElement("failure");
                        xmlWriter.WriteStartElement("message");
                        xmlWriter.WriteCData(result.Message);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndElement();
                }
                WriteChildResults(result);
                xmlWriter.WriteEndElement(); // test-suite
                return;
            } else {
                WriteTestElement(result);
            }
        }

        private void TerminateXmlFile()
        {
            xmlWriter.WriteEndElement(); // test-run
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        private void WriteTestElement(ITestResult result)
        {
            ITest test = result.Test;

            xmlWriter.WriteStartElement("test-case");
            xmlWriter.WriteAttributeString("id", test.Id.ToString ());
            xmlWriter.WriteAttributeString("name", test.Name);
            xmlWriter.WriteAttributeString("fullname", test.FullName);
            xmlWriter.WriteAttributeString("result", result.ResultState.Status.ToString ());
            xmlWriter.WriteAttributeString("label", result.ResultState.Status.ToString ());
            xmlWriter.WriteAttributeString("time", result.Duration.ToString ());
            xmlWriter.WriteAttributeString("asserts", result.AssertCount.ToString ());

            switch (result.ResultState.Status) {
            case TestStatus.Skipped:
            case TestStatus.Inconclusive:
                    WriteReasonElement (result.Message);
                    break;
            case TestStatus.Failed:
                    WriteFailureElement (result.Message, result.StackTrace, result.ExceptionType ?? "UnknownException");
                    break;
            }

            xmlWriter.WriteEndElement ();

        }

        private void WriteReasonElement(string message)
        {
            xmlWriter.WriteStartElement("reason");
            xmlWriter.WriteStartElement("message");
            xmlWriter.WriteCData(message);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        private void WriteFailureElement(string message, string stackTrace, string exceptionType)
        {
            xmlWriter.WriteStartElement("failure");

            xmlWriter.WriteStartElement("message");
            WriteCData(message);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("stack-trace");
            if (stackTrace != null)
                WriteCData(stackTrace);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        private void WriteChildResults(ITestResult result)
        {
            foreach (ITestResult childResult in result.Children)
                WriteResultElement(childResult);
        }

        private void WriteCData(string text)
        {
            int start = 0;
            while (true)
            {
                int illegal = text.IndexOf("]]>", start);
                if (illegal < 0)
                    break;
                xmlWriter.WriteCData(text.Substring(start, illegal - start + 2));
                start = illegal + 2;
                if (start >= text.Length)
                    return;
            }

            if (start > 0)
                xmlWriter.WriteCData(text.Substring(start));
            else
                xmlWriter.WriteCData(text);
        }
    }
}
