using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string exercisePhrase = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";

            string[] phraseWords = exercisePhrase.Split(' ');
            string[] sentences = exercisePhrase.Split('.');
            
            foreach (var word in phraseWords)
            {
                Console.WriteLine($"{word}");
            }

            foreach (var sentence in sentences)
            {
                Console.WriteLine($"{sentence}");
            }
        }
    }
}
