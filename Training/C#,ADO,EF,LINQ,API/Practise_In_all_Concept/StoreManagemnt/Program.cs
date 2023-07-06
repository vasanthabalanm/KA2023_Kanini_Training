using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using StoreManagemnt;

class Program : ConfigurationSection
{
    public static void Main(string[] args)
    {
        Admin admin = new Admin();
        admin.Login();
    }
}
