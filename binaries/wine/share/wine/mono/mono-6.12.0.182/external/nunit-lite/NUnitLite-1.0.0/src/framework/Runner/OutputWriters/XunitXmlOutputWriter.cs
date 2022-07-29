#if MONO
using System;
using System.Globalization;
using System.Reflection;
using System.Xml;
using System.IO;
using NUnit.Framework.Api;
using NUnit.Framework.Internal;
using System.Collections.Generic;

namespace NUnitLite.Runner
{
    /// <summary>
    /// XunitXmlOutputWriter is able to create an xml file representing
    /// the result of a test run in xUnit.net v2 format.
    /// </summary>
    public class XunitXmlOutputWriter : OutputWriter
    {
        private XmlWriter xmlWriter;
        private DateTime startTime;
        private static Dictionary<string, string> resultStates = new Dictionary<string, string>();

        static XunitXmlOutputWriter()
        {
            resultStates["Passed"] = "Pass";
            resultStates["Failed"] = "Fail";
            resultStates["Failed:Error"] = "Fail";
            resultStates["Failed:Cancelled"] = "Fail";
            resultStates["Inconclusive"] = "Skip";
            resultStates["Skipped"] = "Skip";
            resultStates["Skipped:Ignored"] = "Skip";
            resultStates["Skipped:Invalid"] = "Skip";
        }

        public XunitXmlOutputWriter(DateTime startTime)
        {
            this.startTime = startTime;
        }

        public override void WriteResultFile(ITestResult result, TextWriter writer)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(writer);
            xmlWriter.Formatting = Formatting.Indented;

            try
            {
                WriteXmlOutput(result, xmlWriter);
            }
            finally
            {
                writer.Close();
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
            ResultSummary summaryResults = new ResultSummary(result);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("assemblies");

            xmlWriter.WriteStartElement("assembly");

            xmlWriter.WriteAttributeString("name", result.FullName);
            AssemblyName assemblyName = AssemblyHelper.GetAssemblyName(Assembly.GetExecutingAssembly());
            xmlWriter.WriteAttributeString("environment", $"nunit-version: {assemblyName.Version}, clr-version: {Environment.Version}, os-version: {Environment.OSVersion}, platform: {Environment.OSVersion.Platform}, cwd: {Environment.CurrentDirectory}, machine-name: {Environment.MachineName}, user: {Environment.UserName}, user-domain: {Environment.UserDomainName}");
            xmlWriter.WriteAttributeString("test-framework", "nunitlite");
            xmlWriter.WriteAttributeString("run-date", XmlConvert.ToString(startTime, "yyyy-MM-dd"));
            xmlWriter.WriteAttributeString("run-time", XmlConvert.ToString(startTime, "HH:mm:ss"));

            xmlWriter.WriteAttributeString("total", summaryResults.TestCount.ToString());
            xmlWriter.WriteAttributeString("errors", summaryResults.ErrorCount.ToString());
            xmlWriter.WriteAttributeString("failed", summaryResults.FailureCount.ToString());
            xmlWriter.WriteAttributeString("skipped", summaryResults.SkipCount.ToString());

            // TODO: inconclusive? invalid?
            var passedCount = summaryResults.TestCount - summaryResults.FailureCount - summaryResults.SkipCount - summaryResults.NotRunCount;
            xmlWriter.WriteAttributeString("passed", passedCount.ToString());
        }

        private void WriteResultElement(ITestResult result)
        {
            if (result.Test is TestSuite) {
                if ((result.Test as TestSuite).TestType == "Assembly") {
                    WriteChildResults(result);
                    return;
                }
                StartTestElement(result);
                WriteChildResults(result);
                xmlWriter.WriteEndElement(); // test element
            }
            else {
                StartTestElement(result);
                WritePropertiesAndCategories(result);

                switch (result.ResultState.Status)
                {
                    case TestStatus.Skipped:
                    case TestStatus.Inconclusive:
                        WriteReasonElement(result.Message);
                        break;
                    case TestStatus.Failed:
                        WriteFailureElement(result.Message, result.StackTrace, result.ExceptionType ?? "UnknownException");
                        break;
                }

                xmlWriter.WriteEndElement(); // test element
            }
        }

        private void TerminateXmlFile()
        {
            xmlWriter.WriteEndElement(); // assembly
            xmlWriter.WriteEndElement(); // assemblies
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        private void StartTestElement(ITestResult result)
        {
            ITest test = result.Test;
            TestSuite suite = test as TestSuite;

            if (suite != null)
            {
                xmlWriter.WriteStartElement("collection");
                xmlWriter.WriteAttributeString("name", result.Test.FullName);
            }
            else
            {
                xmlWriter.WriteStartElement("test");
                xmlWriter.WriteAttributeString("name", result.FullName);
                xmlWriter.WriteAttributeString("type", result.Test.FixtureType.ToString());
                xmlWriter.WriteAttributeString("method", result.Name);
            }

            TestStatus status = result.ResultState.Status;
            string translatedResult = resultStates[result.ResultState.ToString()];

            xmlWriter.WriteAttributeString("result", translatedResult);
            xmlWriter.WriteAttributeString("time", result.Duration.TotalSeconds.ToString());
        }

        private void WritePropertiesAndCategories(ITestResult result)
        {
            IPropertyBag properties = result.Test.Properties;
            int nprops = 0;

            foreach (string key in properties.Keys)
            {
                foreach (object prop in properties[key])
                {
                    if (nprops++ == 0)
                        xmlWriter.WriteStartElement("traits");

                    xmlWriter.WriteStartElement("trait");
                    xmlWriter.WriteAttributeString("name", key);
                    xmlWriter.WriteAttributeString("value", prop.ToString());
                    xmlWriter.WriteEndElement();
                }
            }

            if (nprops > 0)
                xmlWriter.WriteEndElement();
        }

        private void WriteReasonElement(string message)
        {
            xmlWriter.WriteStartElement("reason");
            xmlWriter.WriteCData(message);
            xmlWriter.WriteEndElement();
        }

        private void WriteFailureElement(string message, string stackTrace, string exceptionType)
        {
            xmlWriter.WriteStartElement("failure");
            xmlWriter.WriteAttributeString("exception-type", exceptionType);
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
#endif
