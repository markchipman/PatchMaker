﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace PatchMaker
{
    /// <summary>
    /// Command line options for PatchMaker
    /// </summary>
    public class Options
    {
        [Option('s', "source", HelpText = "The source directory", Required = true)]
        public string SourceDirectory { get; set; }

        [Option('t', "target", HelpText = "The target directory", Required = true)]
        public string TargetDirectory { get; set; }

        [Option('o', "output", HelpText = "The patch base directory", Required = true)]
        public string PatchBaseDirectory { get; set; }

        [Option('b', "compare-bytes", HelpText = "Do a byte-level comparison", Required = true)]
        public bool CompareBytes { get; set; }

        [HelpOption('?', "help", HelpText = "Show this help screen")]
        public string GetUsage()
        {
            var help = new HelpText
            {
                Heading = new HeadingInfo("PatchMaker", "1.0"),
                Copyright = new CopyrightInfo("Dan Esparza", 2014),
                AddDashesToOption = true
            };

            help.AddOptions(this);

            return help;
        }
    }
}
