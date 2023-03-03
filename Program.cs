using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plan your heist! Please enter a difficulty level (0-100): ");
            int userDifficultyLevel = int.Parse(Console.ReadLine());

            string name = "Test";
            Dictionary<string, TeamMember> Team = new Dictionary<string, TeamMember>();

            int skillTotal = 0;

            while (name != "")
            {
                Console.Write("Enter new team member's name: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    continue;
                }

                Console.Write("Enter new team member's skill level (0-100): ");
                int skillLevel = int.Parse(Console.ReadLine());
                skillTotal += skillLevel;

                Console.Write("Enter new team member's courage level (0.1-2.0): ");
                double courageLevel = Convert.ToDouble(Console.ReadLine());

                TeamMember newMember = new TeamMember(name, skillLevel, courageLevel);

                Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and, on a scale of 0.1 to 2.0, their mom says their courage level is {newMember.CourageLevel}.");
                Team.Add($"{newMember.Name}", newMember);
            }

            Console.Write("How many simulations would you like to run? ");
            int runCount = int.Parse(Console.ReadLine());
            int can = 0;
            int cant = 0;

            for (int i = 0; i < runCount; i++)
            {
                Bank targetBank = new Bank(userDifficultyLevel, "Gringott's");
                int bankDifficulty = targetBank.difficultyLevel;
                Random r = new Random();
                int luck = r.Next(-10, 11);
                int bankDifficultyWithLuck = bankDifficulty + luck;

                Console.WriteLine($"Team Count: {Team.Count}");
                Console.WriteLine($"Team Skill: {skillTotal}");
                Console.WriteLine($"Bank Diffulty: {bankDifficultyWithLuck}");

                if (targetBank.difficultyLevel > skillTotal)
                {
                    Console.WriteLine("It looks like your team doesn't have what it takes for this job.");
                    Console.WriteLine();
                    cant++;
                }
                else
                {
                    Console.WriteLine($"Congratulations, it looks like your team can handle {targetBank.Name}");
                    Console.WriteLine();
                    can++;
                }
            }
            Console.WriteLine($"Simulation Report: Successes: {can}, Failures: {cant}");
        }
    }
}
