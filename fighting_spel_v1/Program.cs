using System;
Random generator = new Random();
int r = generator.Next(0, 10);
int kämpe = 0;

System.Console.WriteLine("Välj din kämpe. Alltnaiv A Joe Bidon. Alltnativ B Karen");

kämpe = Toolbox.kämpe();

if (kämpe == 1) { System.Console.WriteLine("Joe Bidon"); }
if (kämpe == 2) { System.Console.WriteLine("Karen"); }
Console.ReadLine();
