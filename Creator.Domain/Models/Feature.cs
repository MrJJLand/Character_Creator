namespace Creator.Domain.Models
{
    public class Feature
    {
        private string name { get; }
        private string description { get; }
        private int statPlus {get;}

        public void Feature(string newName, string desc, int stat)
        {
            name = newName;
            description = desc;
            statPlus = stat;
        }
    }
}