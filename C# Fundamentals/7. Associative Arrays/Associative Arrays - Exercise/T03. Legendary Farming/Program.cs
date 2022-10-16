using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN_MATERIAL_QTY = 250;

            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne" },
                { "motes", "Dragonwrath" },
                { "fragments", "Valanyr"}
            };

            Dictionary<string, int> materialForLengendaryItem = new Dictionary<string, int>()
            {
                { "shards", 0},
                { "motes", 0},
                { "fragments", 0}
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string itemObtained = string.Empty;

            while (string.IsNullOrEmpty(itemObtained))
            {
                string materialLine = Console.ReadLine().ToLower();
                string[] arrayOfInput = materialLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < arrayOfInput.Length; i += 2)
                {
                    int currMaterialQty = int.Parse(arrayOfInput[i]);
                    string currMaterials = arrayOfInput[i + 1];

                    if (materialForLengendaryItem.ContainsKey(currMaterials))
                    {
                        materialForLengendaryItem[currMaterials] += currMaterialQty;

                        if (materialForLengendaryItem[currMaterials] >= MIN_MATERIAL_QTY)
                        {
                            itemObtained = craftingTable[currMaterials];
                            materialForLengendaryItem[currMaterials] -= MIN_MATERIAL_QTY;

                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currMaterials))
                        {
                            junk[currMaterials] = 0;
                        }
                        junk[currMaterials] += currMaterialQty;
                    }
                }


            }

            Console.WriteLine($"{itemObtained} obtained!");
            foreach (var kvp in materialForLengendaryItem)
            {
                string materialName = kvp.Key;
                int materialQty = kvp.Value;
                Console.WriteLine($"{materialName}: {materialQty}");
            }
            foreach (var kvp in junk)
            {
                string materialName = kvp.Key;
                int materialQty = kvp.Value;
                Console.WriteLine($"{materialName}: {materialQty}");
            }

        }
    }
}
