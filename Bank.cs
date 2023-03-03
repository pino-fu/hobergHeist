using System;

namespace Heist
{
    public class Bank
    {
        public string Name { get; }
        public int difficultyLevel { get; set; }

        public Bank(int difficulty, string name)
        {
            Name = name;
            difficultyLevel = difficulty;
        }
    }
}
