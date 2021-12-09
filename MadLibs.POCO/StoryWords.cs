using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs.POCO
{
    public class StoryWords
    {
        //test test test git push
        public string Month { get; set; }
        public string Exclamation { get; set; }
        public string Holiday { get; set; }
        public string FamilyMember { get; set; }
        public string Ingredient { get; set; }
        public string Animal { get; set; }
        public List<string> Nouns { get; set; }
        public List<string> Verbs { get; set; }
        public List<string> Adjectives { get; set; }
        public List<string> Places { get; set; }
        public List<string> Color { get; set; }
        public List<string> IngVerb { get; set; }
        public List<string> PluralNouns { get; set; }
        public List<string> Numbers { get; set; }
        
        public StoryWords( ){ }
    }
}
