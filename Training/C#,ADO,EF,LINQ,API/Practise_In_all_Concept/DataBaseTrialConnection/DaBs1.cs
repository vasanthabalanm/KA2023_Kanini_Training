using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DataBaseTrialConnection
{
    internal class DaBs1
    {
        SqlConnection conn;
        public void OpenConn()
        {
            //create connection
            conn = new SqlConnection(@"data source=DESKTOP-QCJN09K\SQLEXPRESS; database=DbTrial; integrated security=SSPI");
            conn.Open();
            Console.WriteLine("opened");

        }

        public void CreateTable()
        {
            if(conn!=null)
            {
                conn.Open();
            }
            else
            {
                //create command using sqlcommand
                SqlCommand cmd = new SqlCommand("create table student1(id int not null, name varchar(100), email varchar(50), join_date date)", conn);

                //execute query
                cmd.ExecuteNonQuery();


                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
           

        }
        public void InsertTable()
        {
            // writing sql query  
            SqlCommand cmd = new SqlCommand("insert into student1 (id, name, email, join_date) values ('102', 'modi', 'modi@example.com', '1/12/2013')", conn);

            // Executing the SQL query  
            cmd.ExecuteNonQuery();

            // Displaying a message  
            Console.WriteLine("Record Inserted Successfully");
        }
        public void UpdtaeTable()
        {
            SqlCommand cmd = new SqlCommand("update dtudent1 set name='sample'  ", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("updated successfully");

        }

        public void ReadQuery()
        {

            // writing sql query  
            SqlCommand cm = new SqlCommand("Select * from student1", conn);

            // Executing the SQL query  
            SqlDataReader sdr = cm.ExecuteReader();
            
            while(sdr.Read())
            {
                Console.WriteLine(sdr["id"]);
            }
            //Console.WriteLine(sdr);
        }
        public void CloseConn()
        {
            conn.Close();
            Console.WriteLine("Connecition closed");
        }
        public void Countofstud()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from student1",conn);
            object res = cmd.ExecuteScalar();
            if(res!=null)
            {
                Console.WriteLine(res.ToString());
            }
        }
        public void FetchDataStoreProcedure()
        {
            SqlCommand cmd = new SqlCommand("udp_checksum", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parameter = cmd.Parameters.Add("@id",SqlDbType.Int);
            /*SqlParameter parameter = cmd.Parameters.Add("@fullname", SqlDbType.NVarChar,50);
            parameter.Value = "amit";
            parameter = cmd.Parameters.Add("@email", SqlDbType.NVarChar,50);
            parameter.Value = "amit12@gmail.com";
            parameter = cmd.Parameters.Add("@password", SqlDbType.NVarChar,50);
            parameter.Value = "amit13@";
            parameter = cmd.Parameters.Add("@customerid", SqlDbType.Int);
            parameter.Direction = ParameterDirection.ReturnValue;*/



            //User input
            //Console.ReadLine(parameter.Value);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
               
                
                Console.WriteLine(sdr["id"]);
            }
            //parameter = cmd.Parameters["@customerid"];
            //Console.WriteLine("customer id "+parameter.Value);
            //int cou = cmd.ExecuteNonQuery ();
            //Console.WriteLine(cou);

        }

    }
        
    
}
