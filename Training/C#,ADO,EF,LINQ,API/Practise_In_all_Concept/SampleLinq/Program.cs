using SampleLinq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
//declare delegate
delegate bool EligibityCheck(people per);
class program
{
    public static void Main(string[] args)
    {
        /*people[] peoples = new people[]
        {
            { }
        }*/
        people[] peoples =
        {
            new people(){ Name="balan",Age=21},
            new people(){ Name="Adhish",Age=12},
            new people(){ Name="aswin",Age=20},
            new people(){ Name="vicky",Age=11},
            new people(){ Name="bala",Age=21},
            new people(){ Name="sudharson",Age=14},
            new people(){ Name="kishore",Age=19},
            new people(){ Name="surya",Age=38},
            new people(){ Name="yuvaraj",Age=21},
            new people(){ Name="vishnu",Age=12},
            new people(){ Name="suryab",Age=38},

        };

        /*people[] voters = new people[peoples.Length];
        int i = 0;
        foreach(people p in peoples)
        {
            if (p.Age >= 18)
            {
                voters[i] = p; 
                Console.WriteLine(p.Name);
                i++;
            }
        }*/
        /*
        List<people> voters = Voters.where(peoples, delegate (people pe)
        {
            return pe.Age >= 18;

        });
        foreach (people vote in voters)
        {
            Console.WriteLine(vote.Name);
        }*/

        //are in linq code
        //List <people> vot = peoples.Where(p => p.Age>=18).ToList();

        /*var vot = from people in peoples
                  where people.Age >= 18 && people.Name.StartsWith("s")
                    
                   select people;


         foreach (people pp in vot)
         {
             Console.WriteLine(pp.Name);
         }*/

        Sample1 sample1 = new Sample1();
        //sample1.filrtype();
        sample1.studlst();

        //Student[] students = new Student



    }
}