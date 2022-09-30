using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnging
{
    public class ClassSelector
    {
        List<String> names;
        public ClassSelector(List<String> names)
        {
            this.names = names;
        }
        public void print()
        {
            Random random = new Random();
            
            foreach (var name in names)
            {
                int n = random.Next(0, names.Count);
                System.Console.WriteLine(names[n]);
            }
            
        }
    }
}