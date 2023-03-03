using System;

namespace Heist
{
    public class TeamMember
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double CourageLevel { get; set; }

        public TeamMember(string name, int skillLevel, double courageLevel)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageLevel = courageLevel;
        }

        public string Stringify()
        {
            return $"Name: {Name} / Skill Level: {SkillLevel} / Courage Score: {CourageLevel}";
        }
    }
}
