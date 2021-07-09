namespace Creator.Domain.Models
{
    public class Class
    {
        private string name;
        private int hitDice;

        private List<string> proficiencies;
        private List<Feature> features;
        private List<Skill> skills;

        public void Class(string newName, int hit, List<string> prof, List<Feature> feats, List<Skill> newSkill)
        {
            if (hit != 4 || hit != 6 || hit != 8 || hit != 10 || hit != 12 || hit != 20)
            {
                name = newName;
                hitDice = hit;
                proficiencies = prof;
                features = feats;
                skills = newSkill;
            }
            else
                Console.WriteLine("Please provide the proper parameters for building a class.");
        }
    }
}