using NUnit.Framework;
using HashTableandBinaryTree;

namespace NUnitTestProject1
{
    public class Tests
    {
        /// <summary>
        /// TC-1 Test to check frequency of words in a sentence
        /// </summary>
        [Test]
        public void GivenASentence_WhenWordsAreAddedToList_ShouldReturnWordFrequency()
        {
            string sentence = "To be or not to be";
            MyHashMap myHashMap = new MyHashMap();
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = myHashMap.get(word);
                if (value == 0) value = 1;
                else value = value + 1;
                myHashMap.add(word, value);
            }

            int frequency = myHashMap.get("to");
            Assert.AreEqual(2, frequency);
        }
    }
}