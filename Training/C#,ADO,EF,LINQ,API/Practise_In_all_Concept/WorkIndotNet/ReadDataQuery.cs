using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkIndotNet
{
    internal class ReadDataQuery
    {
        LinqtoSqlDataContext DataContext = new LinqtoSqlDataContext();
       /* public void ReadData()
        {
            var res = DataContext.student1s.Where(st => st.id == 101);

            foreach(var item in res)
            {
                Console.WriteLine(item.email);
            }
        }

        public void Agreegte()
        {
            //query syntax
            int res1 = (from s in DataContext.student1s select s.id).Count();
            Console.WriteLine(res1);

            int res2 = (from s in DataContext.student1s select s.id).Min();
            Console.WriteLine(res2);


            //meathod syntax
            int res = DataContext.student1s.Select(st => st.id).Max();
            Console.WriteLine(res);

            double res3 = DataContext.student1s.Select(st => st.id).Average();
            Console.WriteLine(res3);

        }*/
        public void joinsa()
        {
            var res = DataContext.Regions.Join(DataContext.Customer_Nodes, 
                                                e => e.region_id, 
                                                t => t.region_id, 
                                                (e, t) => new
                                                {
                                                    regid = e.region_id,
                                                    custran = t.customer_id
                                                }
            );

            foreach ( var r in res )
            {
                Console.WriteLine( r.regid+" "+r.custran );
            }
        }
    }
}
