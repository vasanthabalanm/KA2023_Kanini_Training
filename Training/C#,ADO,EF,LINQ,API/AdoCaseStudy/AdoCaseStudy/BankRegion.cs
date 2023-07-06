using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using System.Data;

namespace AdoCaseStudy
{
    internal class BankRegion
    {

        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public void OpenConn()
        {
            //create connection
            conn = new SqlConnection("data source=DESKTOP-QCJN09K\\SQLEXPRESS; database=Adocase_study; integrated security=SSPI");
            conn.Open();
            Console.WriteLine("opened");

        }
        public void ReadData()
        {
            da = new SqlDataAdapter("select * from Regions", conn);
            ds = new DataSet();
            da.Fill(ds, "d1");

            foreach (DataRow dr in ds.Tables["d1"].Rows)
            {
                Console.WriteLine(dr[0].ToString() + dr[1].ToString());
            }
            conn.Close();
        }
       
        
        
       
    }
}
