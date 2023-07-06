using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkIndotNet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinqtoSqlDataContext DataContext = new LinqtoSqlDataContext();
            

            //query syntax
            /*var res = from s in DataContext.student1s
                      select s;
            
             
             foreach(var r in res)
            {
                Console.WriteLine(r.id +" "+ r.name);
            }
            Console.ReadLine();
            */

            /*var res = DataContext.student1s.Select(st => st.id==101);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }*/

            /*var res = DataContext.student1s.Where(st => st.id == 101);

            foreach(var item in res)
            {
                Console.WriteLine(item.email);
            }*/

            //ReadDataQuery readDataQuery = new ReadDataQuery();
            //readDataQuery.ReadData();
            //readDataQuery.Agreegte();
            //readDataQuery.joinsa();

            
        }
    }
}
