using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist");

            string name = "Ben";
            Dictionary<string, TeamMember> Team = new Dictionary<string, TeamMember>();

            while (name != "")
            {
                Console.Write("Enter new team member's name:");
                name = Console.ReadLine();
                    if (name == "")
                    {
                        continue;
                    }

                    Console.Write("Enter new team member's skill level:");
                    int skillLevel = int.Parse(Console.ReadLine());

                    Console.Write("Enter new team member's courage level:");
                    double courageLevel = Convert.ToDouble(Console.ReadLine());

                    TeamMember newMember = new TeamMember(name, skillLevel, courageLevel);

                    Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and, on a scale of 0.1 to 2.0, their mom says their courage level is {newMember.CourageLevel}.");
                    Team.Add($"{newMember.Name}", newMember);
            }
            Console.WriteLine($"Team Count: {Team.Count}");
            foreach (KeyValuePair<string, TeamMember> each in Team)
            {
                Console.WriteLine(each.Value.Stringify());
            }
        }
    }
}
