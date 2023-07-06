using AdoCaseStudy;
using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            BankRegion region = new BankRegion();
            region.OpenConn();
            region.ReadData();
            //ddb.InsrtRced(12,"parameterpass");
            //ddb.Updaterec(1);
            //ddb.Insrtable();
            //ddb.DeleteRec(102);



        }
    }
}