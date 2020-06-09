﻿  
using System;
using System.Collections.Generic;
using ifmo.tpo.lab1.Models;

namespace ifmo.tpo.lab1.Commons
{
    public class Settings
    {
        public static readonly Option Action = new Option("Action", new List<string>() { "query", "help" }, "query");
        public static readonly Option Errors = new Option("Errors", new List<string>() { "default", "detailed" }, "default");
        public static readonly Option Format = new Option("Format", new List<string>() { "json", "xml", "xhtml", "raw" }, "json");
        public static readonly Option Order = new Option("Order", new List<string>() { "alphabet", "random", "date" }, "alphabet");



    }
}
