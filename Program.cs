using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace atomSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void WriteJson(List<Atom> atoms, string filename)
        {
            var jsonString = JsonSerializer.Serialize(atoms);
            File.WriteAllText(filename, jsonString);
        }

        static void ReadJson(string filename)
        {
            var jsonString = File.ReadAllText(filename);
            var atoms = JsonSerializer.Deserialize<List<Atom>>(jsonString);

            foreach (var atom in atoms)
            {
                Console.WriteLine(atom.ToString());
            }
        }
    }
}