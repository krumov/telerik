using System;
using System.Collections.Generic;

class Product
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Cost { get; set; }
 
        public override string ToString()
        {
            return string.Format("[ Name = {0}, Weight = {1}, Cost = {2} ]",
                this.Name, this.Weight, this.Cost);
        }
    }

class Program
{
    static void Main(string[] args)
    {
        int N = 6;
        int M = 10;
        Product[] products = new Product[]
            {
                new Product(){ Name = "beer", Weight = 3, Cost = 2 },
                new Product(){ Name = "vodka", Weight = 8, Cost = 12 },
                new Product(){ Name = "cheese", Weight = 4, Cost = 5 },
                new Product(){ Name = "nuts", Weight = 1, Cost = 4 },
                new Product(){ Name = "ham", Weight = 2, Cost = 3 },
                new Product(){ Name = "whiskey", Weight = 8, Cost = 13 }
            };

        // stores the optimal solution for the given problem
        // the key is the total cost
        // the value is the list of products in the knapsack
        KeyValuePair<int, List<Product>> optimalSolution =
            new KeyValuePair<int, List<Product>>(0, new List<Product>());
        long maxCombinations = (long)Math.Pow(2, N);

        // try every possible combination
        for (int i = 0; i < maxCombinations; i++)
        {
            // generate combinations using binary vectors
            string binaryVector = Convert.ToString(i, 2).PadLeft(N, '0');
            List<Product> currentSolution = new List<Product>();
            int totalCost = 0;
            int totalWeight = 0;
            for (int j = 0; j < N; j++)
            {
                if (binaryVector[j] == '1')
                {
                    currentSolution.Add(products[j]);
                    totalCost += products[j].Cost;
                    totalWeight += products[j].Weight;
                }
            }

            if (totalWeight <= M && totalCost > optimalSolution.Key)
            {
                optimalSolution = new KeyValuePair<int, List<Product>>(
                    totalCost, currentSolution);
            }
        }

        Console.WriteLine("Optimal solution: ");
        Console.WriteLine(string.Join("\n", optimalSolution.Value));
        Console.WriteLine("Total cost: {0}", optimalSolution.Key);
    }
}
