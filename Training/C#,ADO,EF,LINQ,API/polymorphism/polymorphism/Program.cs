using polymorphism;

class Program
{
    public static void Main(String[] args)
    {
        Bnkacc bkac = new Bnkacc(1234,23313434,"boopathy",60000,"Inactive");
        Console.WriteLine("1.Custid 2.Accno");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                bkac.CheckStats(1233, out int accno, out string name, out double balance, out string status);
                    break;
            case 2:
                bkac.CheckStats(12677657634, out int custid, out string sname, out double sbalance, out string sstatus);
                    break;

        }
    }
}
