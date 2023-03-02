using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist.");
            Console.WriteLine();
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your skill level?");
            int skill = int.Parse(Console.ReadLine());
            Console.WriteLine("On a scale of 0.0 to 2.0, how courageous does your mom say you are?");
            double courage = Convert.ToDouble(Console.ReadLine());

            TeamMember newMember = new TeamMember(name, skill, courage);

            Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and, on a scale of 1 to 2, they're {newMember.CourageLevel} nervous");
        }
    }
}
