﻿using System.Collections.Generic;

namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying HashTable Program");
            //UC_1
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "Be");
            hash.Add("2", "Or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "Be");

            string hash0 = hash.Get("0");
            Console.WriteLine("0th : " + hash0);

            string hash1 = hash.Get("1");
            Console.WriteLine("1st : " + hash1);

            string hash2 = hash.Get("2");
            Console.WriteLine("2nd : " + hash2);

            string hash3 = hash.Get("3");
            Console.WriteLine("3rd : " + hash3);

            string hash4 = hash.Get("4");
            Console.WriteLine("4th : " + hash4);

            string hash5 = hash.Get("5");
            Console.WriteLine("5th : " + hash5);

            
        }
    }
}