using System;

namespace HashTableandBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hashmap");

            string Input = "To be or not to be";
            MyHashMap myHashMap = new MyHashMap();
            string[] words = Input.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = myHashMap.get(word);
                if (value == 0) value = 1;
                else value = value + 1;
                myHashMap.add(word, value);
            }


            int frequency = myHashMap.get("to");
            Console.WriteLine(frequency);
            Console.WriteLine(myHashMap);
        }
    }
}