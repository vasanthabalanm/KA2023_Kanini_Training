using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLinq
{
    internal class Sample1
    {
        public void samp()
        {
            List<string> course = new List<string>();
            course.Add("c");

            var tut = from c in course where c.Contains("c") select c;

            foreach (var t in tut)
            {
                course.Add(t.ToString());
            }
        }

        public void filrtype()
        {
            IList element = new ArrayList();
            element.Add(1);
            element.Add("A");
            element.Add(2.013);
            element.Add("Because");
            element.Add(true);
            element.Add(-12.3);
            element.Add('P');
            foreach(var t in element)
            {
                Console.WriteLine(t);
            }
            //query syntax
            //var contin = from e in element.OfType<string>() select e;
            //var numbr = from e in element.OfType<int>() select e;

            //meathod syntax
            var contin = element.OfType<string>();
            var numbr = element.OfType<int>();

            foreach (var str in contin)
            {
                Console.WriteLine(str);
            }
            /*foreach(int n in numbr)
            {
                Console.WriteLine(n);
            }*/

        }
        public void studlst()
        {
            IList<Student> std = new List<Student>()
            {
                new Student() { stuid=1,name = "boojoo",age=21},
                new Student() { stuid=2,name = "jooboo",age=11},
                new Student() { stuid=3,name="jooboo",age=32},
            };

            //query syntax for orderby
            /*var res = from Student in std
                      orderby Student.name 
                      select Student;*/

            //meathod syntax for orderby
            //var res = std.OrderByDescending(s=>s.name).ThenByDescending(s=>s.age);

            /*foreach (var ok in res)
            {
                Console.WriteLine(ok.name + " " + ok.age);
            }*/


            //query synrax for groupby
            /*var res = from s in std
                      group s by s.name;*/


            //meathod syntax for groupby

            /*var res = std.GroupBy(s => s.name);

            foreach (var sd in res)
            {
                Console.WriteLine(sd.Key);
                foreach(var x in sd)
                {
                    Console.WriteLine(x.stuid+" "+x.age);
                }
            }*/


            var res = std.ToLookup(s => s.name);
            foreach (var x in res)
            {
                Console.WriteLine(x.Key);
            }
        }

    }
}
