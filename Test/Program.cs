using DocumentFactory;
using DocumentFactory.Html;
using DocumentFactory.Markdown;
using DocumentFactory.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Test
{
    /// <summary>
    /// Client program.
    /// Assumption: The script is placed at the directory where the Program executable resides.
    /// And the script must be named CreateDocumentScript.txt
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands;
            var list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#'); // or perhaps lines

            // Determines if the document is Html5.
            bool isHtml = false;

            // File name as specified in script.
            string documentName = null;

            // Current element type detected in script.
            string elementType = null;

            // The props to instantiate current element.
            string props = null;

            // The document object itself (either Html or Markdown).
            // Throughout the script, there could be multiple documents to create,
            // But we just need a single IDocument object to handle all requests.
            IDocument document = null;

            // The generic document factory. Its type is to be determined at runtime.
            IDocumentFactory documentFactory = null;

            // The abstract document element. It will be dynamically determined at runtime.
            IElement element = null;

            // Iterates the script line by line
            foreach (var command in commands)
            {
                // Strips out all the white space characters
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");

                var commandList = strippedCommand.Split(':');
                switch (commandList[0])
                {
                    case "Document":
                        isHtml = commandList[1].Contains("Html");
                        documentName = commandList[1].Substring(commandList[1].IndexOf(";") + 1);
                        documentFactory = Helper.GetDocumentFactory(commandList[1].Split(';')[0]);
                        document = documentFactory.CreateDocument(documentName);
                        break;
                    case "Element":
                        elementType = commandList[1];
                        props = commandList[2];
                        element = documentFactory.CreateElement(elementType, props);
                        document.AddElement(element);
                        break;
                    case "Run":
                        document.RunDocument();
                        Process.Start(Helper.GetChromeExecutable(), GetAbsolutePathToFile(documentName));
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Given the document name (e.g. index.html), returns the absolute path
        /// to the file on disk. Typically at the same directory as the Program's executable.
        /// </summary>
        /// <param name="documentName"></param>
        /// <returns></returns>
        private static String GetAbsolutePathToFile(string documentName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string absolutePathToDocument = $"--homepage file:///{currentDirectory}/{documentName}";
            return absolutePathToDocument;
        }
    }
}
