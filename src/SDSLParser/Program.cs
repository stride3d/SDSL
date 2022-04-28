﻿using Eto.Parse;
using Eto.Parse.Grammars;
using Stride.Shader.Parser;
using System.Diagnostics;


var shaderf = File.ReadAllText("./SDSL/Expressions.sdsl");

// var parser = new SDSLGrammar();
var parser = StrideGrammar.New("sum");
var tokens = StrideGrammar.HlslGrammar("expression");
var s = new Stopwatch();
var match = tokens.Match("(8)");
s.Start();
match = tokens.Match(shaderf);
s.Stop();

Console.WriteLine(match.ErrorMessage[..(Math.Min(300,match.ErrorMessage.Length))]);
match.Matches.ForEach(x => Console.WriteLine(x.Name + " : " + x.Value));
Console.WriteLine($"parsing time : {s.Elapsed}");
Console.Write("");


