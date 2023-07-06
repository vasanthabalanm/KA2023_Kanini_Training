using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTrialConnection
{
    internal class AdoCase
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public void OpenConn()
        {
            //create connection
            conn = new SqlConnection(@"data source=DESKTOP-QCJN09K\SQLEXPRESS;Initial catalog=Adocase_study; integrated security=SSPI");
            conn.Open();
            Console.WriteLine("opened");

        }
        public void ques1()
        {
            da = new SqlDataAdapter("select Regions.region_name, count(Distinct Customer_Nodes.node_id)as node_counts from Regions inner join Customer_Nodes on Regions.region_id = Customer_Nodes.region_id group by Regions.region_name;\r\n", conn);
            ds = new DataSet();
            da.Fill(ds, "ado1");

            foreach (DataRow dr in ds.Tables["ado1"].Rows)
            {
                Console.WriteLine(dr[0].ToString() +"   "+ dr[1].ToString());
            }
            conn.Close();
        }
        public void ques2()
        {
            da = new SqlDataAdapter("select Regions.region_name, count(Distinct Customer_Nodes.customer_id) as customer_counts from Customer_Nodes inner join Regions on Customer_Nodes.region_id=Regions.region_id group by Regions.region_name;", conn);
            ds = new DataSet();
            da.Fill(ds, "ado1");
            Console.WriteLine("Region name ,    customer_counts");
            foreach (DataRow dr in ds.Tables["ado1"].Rows)
            {
                Console.WriteLine(dr[0].ToString() + "          " + dr[1].ToString());
            }
            conn.Close();
        }
        public void ques3()
        {
            da = new SqlDataAdapter("select count(*) Total_count , AVG(txn_amount) Average_amount from Customer_transactions where txn_type='deposit'", conn);
            ds = new DataSet();
            da.Fill(ds, "ado1");
            Console.WriteLine("TotalCounts , Average_Amount");
            foreach (DataRow dr in ds.Tables["ado1"].Rows)
            {
                Console.WriteLine(dr[0].ToString() + "             " + dr[1].ToString());
            }
            conn.Close();
        }
        public void ques4()
        {
            da = new SqlDataAdapter("WITH All_customer as (SELECT customer_id, DATEPART(MONTH,txn_date) as month,SUM(CASE WHEN txn_type ='deposit' then txn_amount else 0 end) as deposit, SUM(CASE WHEN txn_type ='purchase' then -txn_amount else 0 end) as purchase , SUM(CASE WHEN txn_type ='withdrawal' then -txn_amount else 0 end)  as  withdrawal from customer_transactions GROUP BY customer_id,DATEPART(MONTH,txn_date)),All_customer_2 AS (SELECT customer_id,month,(deposit +purchase +withdrawal) as total from All_customer) SELECT customer_id, month, SUM(total) OVER (PARTITION BY customer_id ORDER BY customer_id,month  ROWS BETWEEN UNBOUNDED PRECEDING AND current ROW) AS balance FROM All_customer_2", conn);
            ds = new DataSet();
            da.Fill(ds, "ado1");
            Console.WriteLine("cus_id, mon, bal");
            foreach (DataRow dr in ds.Tables["ado1"].Rows)
            {
                Console.WriteLine(dr[0].ToString() + "     " + dr[1].ToString() + "    " + dr[2].ToString());
            }
            conn.Close();
        }
        public void ques5()
        {
            da = new SqlDataAdapter("WITH All_customer as (SELECT customer_id, DATEPART(MONTH,txn_date) as month,SUM(CASE WHEN txn_type ='deposit' then txn_amount else 0 end) as deposit, SUM(CASE WHEN txn_type ='purchase' then -txn_amount else 0 end) as purchase , SUM(CASE WHEN txn_type ='withdrawal' then -txn_amount else 0 end)  as  withdrawal from customer_transactions GROUP BY customer_id,DATEPART(MONTH,txn_date)),All_customer_2 AS (SELECT customer_id,month,(deposit +purchase +withdrawal) as total from All_customer) SELECT count(*) AS change_in_balance FROM All_customer_2;", conn);
            ds = new DataSet();
            da.Fill(ds, "ado1");
            Console.WriteLine("Closing balance compare to previous month");
            foreach (DataRow dr in ds.Tables["ado1"].Rows)
            {
                
                Console.WriteLine(dr[0].ToString() );
            }
            conn.Close();
        }


    }
}
