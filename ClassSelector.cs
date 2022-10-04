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
        int number;
        public ClassSelector(List<String> names, int number)
        {
            this.names = names;
            this.number = number;
        }
        public void print()
        {
            var rnd = new Random();
            var numbers = Enumerable.Range(0, names.Count).OrderBy(x => rnd.Next()).Take(number).ToList();
            foreach (var number in numbers)
            {
                Console.WriteLine(names[number]);
            }
        }
    }
}