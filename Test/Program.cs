using DocumentFactory;
using DocumentFactory.Html;
using DocumentFactory.Markdown;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands;
            //var list = File.ReadAllText("CreateDocumentScript.txt // html
            //var list = File.ReadAllText("CreateDocumentScriptMd.txt"); // markdown
            var list = File.ReadAllText("CreateDocumentScriptFinal.txt");
            commands = list.Split('#'); // or perhaps lines

            bool isHtml = false;
            string documentName = null;
            string elementType = null;
            string props = null;
            IDocument document = null;

            // Iterates line by line
            foreach (var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                var commandList = strippedCommand.Split(':');
                switch (commandList[0])
                {
                    case "Document":
                        isHtml = commandList[1].Contains("Html");
                        documentName = commandList[1].Substring(commandList[1].IndexOf(";") + 1);
                        if (isHtml)
                        {
                            document = HtmlFactory.GetHtmlFactoryInstance().CreateDocument(documentName);
                        }
                        else
                        {
                            document = MarkdownFactory.GetMarkdownFactoryInstance().CreateDocument(documentName);
                        }
                        break;
                    case "Element":
                        elementType = commandList[1];
                        props = commandList[2];
                        if (isHtml)
                        {
                            IElement element = HtmlFactory.GetHtmlFactoryInstance().CreateElement(elementType, props);
                            document.AddElement(element);
                        }
                        else
                        {
                            IElement element = MarkdownFactory.GetMarkdownFactoryInstance().CreateElement(elementType, props);
                            document.AddElement(element);
                        }
                        break;
                    case "Run":
                        document.RunDocument();
                        string currentDirectory = Directory.GetCurrentDirectory();
                        string absolutePathToDocument = $"--homepage file:///{currentDirectory}/{documentName}";
                        System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", absolutePathToDocument);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
