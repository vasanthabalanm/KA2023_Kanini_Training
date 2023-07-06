using DataBaseTrialConnection;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

class Program : ConfigurationSection
{
    public static void Main(String[] args) 
    {
        /*DbDisconnectedArch ddb = new DbDisconnectedArch();
        ddb.OpenConn();
        ddb.ReadData();
        //ddb.InsrtRced(12,"parameterpass");
        //ddb.Updaterec(1);
        ddb.Insrtable();
        //ddb.DeleteRec(102);*/

        /*
        Console.WriteLine("the value get number 1 in app.config file");
        Console.WriteLine(ConfigurationManager.AppSettings["number1"]);

        string connstr = ConfigurationManager.ConnectionStrings["Students1"];

        /*StringBuilder sb = new StringBuilder("data source=");
        Console.WriteLine("enter the data source");
        sb.Append(Console.ReadLine());
        sb.Append(";")
       SqlConnection conn = new SqlConnection();

        create connection
        conn = new SqlConnection("data source=.; database=student; integrated security=SSPI");

        //connection open
        conn.Open();

        //create command using sqlcommand
        SqlCommand cmd = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", conn);

        //execute query
        cmd.ExecuteNonQuery();


        // Displaying a message  
        Console.WriteLine("Table created Successfully");

        //connection close
        conn.Close();*/

        //DaBs1 daBs1 = new DaBs1();
        //daBs1.OpenConn();
        // daBs1.CreateTable();
        // daBs1.InsertTable();
        //daBs1.UpdtaeTable();
        //daBs1.Countofstud();
        //daBs1.FetchDataStoreProcedure();

        AdoCase adoCase = new AdoCase();
        adoCase.OpenConn();
        Console.WriteLine();
        Console.WriteLine("1. Display the number of nodes per region");
        Console.WriteLine();

        adoCase.ques1();
        Console.WriteLine();

        Console.WriteLine("2. Display the number of customers allocated to each region");
        Console.WriteLine();

        adoCase.ques2();
        Console.WriteLine();

        Console.WriteLine("3. Display the total count and average amount of deposits for all the customers");
        Console.WriteLine();

        adoCase.ques3();
        Console.WriteLine();

        Console.WriteLine("4. Display the closing balance for each customer at the end of the month");
        Console.WriteLine();

        adoCase.ques4();
        Console.WriteLine();

        Console.WriteLine("5. Display the number of customers who have increased their closing balance compared to the previous month.");
        Console.WriteLine();

        adoCase.ques5();
        //adoCase.Countofstud();


        //daBs1.ReadQuery();
        //daBs1.FetchDataStoreProcedure();

        //daBs1.CloseConn();


    }
}