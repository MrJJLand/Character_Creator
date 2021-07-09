using System;

namespace creator.client
{
    class Program
    {
        static void Main(string[] args)
        {
            Skill newSkill = new Skill("Acrobatics", "Used to do cool tricks");
            Console.WriteLine(newSkill.name);
        }
    }
}
