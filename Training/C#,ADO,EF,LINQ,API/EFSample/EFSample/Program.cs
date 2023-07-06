//code frst approach
//create domain name first create class
using EFSample;
using System.Transactions;

class Program
{
    public static void Main(string[] args)
    {
        CRudOperation cRud = new CRudOperation();
        //cRud.InsertRecordsInCouseEntity();
        //Console.WriteLine("Insert course successfully");
        //cRud.InsertRecordsInStudentEntity();
        //Console.WriteLine("Insert student successfully done");
        //cRud.UpdateRecordsInStudentEntity();
        //Console.WriteLine("updated successfully");
        //cRud.DeleteRecordsInStudentEntity();
        //Console.WriteLine("Deletedsuccessfully");
        
        Console.WriteLine("enter the name to get count");
        string str1 = Console.ReadLine();
        cRud.QueryMetd(str1);

    }
}

