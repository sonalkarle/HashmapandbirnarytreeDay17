using HashTableandBinaryTree;
using System;

namespace HashTableAndBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Input = "Paranoids are not paranoid they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            MyLinkedHashMap myLinkedHashMap = new MyLinkedHashMap();
            string[] words = Input.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = myLinkedHashMap.get(word);
                if (value == 0) value = 1;
                else value = value + 1;
                myLinkedHashMap.add(word, value);
            }
            myLinkedHashMap.remove("avoidable");
            int frequency = myLinkedHashMap.get("avoidable");

            Console.WriteLine(frequency);
        }
    }
}