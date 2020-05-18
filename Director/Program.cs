﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Director
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] commands;
            var list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');

            foreach (var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                var commandList = strippedCommand.Split(':');
                switch (commandList[0])
                {
                    case "Document":
                        // Your document creation code goes here
                        break;
                    case "Element":
                        // Your element creation code goes here
                        break;
                    case "Run":
                        // Your document running code goes here
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
