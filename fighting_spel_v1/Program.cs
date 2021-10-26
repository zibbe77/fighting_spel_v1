using System;

string[] kampe = new string[2];

kampe = Toolbox.vika();

System.Console.WriteLine($"{kampe[0]} och {kampe[1]} är redo");
Console.ReadLine();

Toolbox.slags(kampe);

