using System.Collections.Generic;

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
            Console.WriteLine("-----------------------------");
            //UC_2
            MyMapNode<int, string> map = new MyMapNode<int, string>(1);
            map.Add(0, "“Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
            string map0 = map.Get(0);
            Console.WriteLine(map0);

            Console.WriteLine("\nFrequency of Words ==> ");

            string[] arr = new string[map.size];
            for (int i = 0; i < map.size; i++)
            {
                arr[i] = map.Get(0);
            }
            map.FreqOfWords(arr, arr.Length);
            Console.ReadLine();
            Console.WriteLine("-----------------------------");
            //UC_3
            MyMapNode<int, string> node = new MyMapNode<int, string>(19);
            node.Add(0, "Paranoids");
            node.Add(1, "are");
            node.Add(2, "not");
            node.Add(3, "paranoid");
            node.Add(4, "because");
            node.Add(5, "they");
            node.Add(6, "are");
            node.Add(7, "paranoid");
            node.Add(8, "but");
            node.Add(9, "because");
            node.Add(10, "they");
            node.Add(11, "keep");
            node.Add(12, "putting");
            node.Add(13, "themselves");
            node.Add(14, "deliberately");
            node.Add(15, "into");
            node.Add(16, "paranoid");
            node.Add(17, "avoidable");
            node.Add(18, "situations");

            for (int i = 0; i < node.size; i++)
            {
                Console.WriteLine($"{i} index value : {node.Get(i)}");
            }

            Console.WriteLine("\nRemoving a Word from Para ==>");
            node.Remove(10);

            for (int i = 0; i < node.size; i++)
            {
                Console.WriteLine($"{i} index value : {node.Get(i)}");
            }

            Console.ReadLine();
        }



    }
    
}