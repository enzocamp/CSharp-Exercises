﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Couse
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

            HashSet<int> st = new HashSet<int>();

            foreach (int x in result) { 
                st.Add(x);
            }
        }
    }
}