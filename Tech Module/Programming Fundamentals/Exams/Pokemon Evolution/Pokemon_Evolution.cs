using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Evolution
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pokemonDict = new Dictionary<string, List<Evolution>>();

            while (input != "wubbalubbadubdub")
            {
                var pokemons = input.Split(' ').Select(s => s.Trim()).ToList();
                var pokemonName = pokemons[0];

                if (pokemons.Count == 1 && pokemonName != "wubbalubbadubdub")
                {
                    foreach (var pair in pokemonDict)
                    {
                        if (pair.Key == pokemonName)
                        {
                            var pokemon = pair.Value.ToList();
                            var sort = from element in pokemon select element;

                            Console.WriteLine("# {0}", pair.Key);

                            foreach (var member in sort)
                            {
                                Console.WriteLine("{0} <-> {1}", member.type, member.index);
                            }
                        }
                    }
                    goto Next;
                }

                var typeEvo = pokemons[2];
                var indexEvo = int.Parse(pokemons[4]);
                var evolution = new Evolution { type = typeEvo, index = indexEvo};
                var containsKey = false;

                foreach (var pair in pokemonDict.Keys)
                {
                    if (pair.Contains(pokemonName))
                    {
                        pokemonDict[pokemonName].Add(evolution);
                        containsKey = true;
                    }
                }

                if (!containsKey)
                {
                    pokemonDict.Add(pokemonName, new List<Evolution>());
                    pokemonDict[pokemonName].Add(evolution);
                }

            Next: input = Console.ReadLine();
            }

            foreach (var pair in pokemonDict)
            {
                var pokemon = pair.Value.ToList();
                var sort = from element in pokemon orderby element.index descending, element.type select element;

                Console.WriteLine("# {0}", pair.Key);

                foreach (var member in sort)
                {
                    Console.WriteLine("{0} <-> {1}", member.type, member.index);
                }
            }
        }
    }
}

public class Evolution
{
    public string type { get; set; }
    public int index { get; set; }
}

