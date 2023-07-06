using abstractionclass;

class Program
{
    public static void Main(String[] args)
    {
        /* class1 intst = new class1(10, 1110, "vishal", 50000, 0);

         double intialamount = intst.calculateinterset();
         Console.WriteLine(intst.Intialamount);*/

        /*Connect_interface_as_Derived connect_Interface_As_Derived = new Connect_interface_as_Derived();
        Console.WriteLine( connect_Interface_As_Derived.intadd(2,4));
        Console.WriteLine(connect_Interface_As_Derived.stradd("bala", "murugan"));*/

        Animals dog = new Animals("dog", 2, 1, 4, 1);
        Animals cow = new Animals("cow", 2, 1, 4, 1);
        Animals cat = new Animals("cat", 2, 1, 4, 1);
        cat.Sounds(cat.Name);
        cow.type(cow.Name);
        dog.type(dog.Name);
        dog.Sounds(dog.Name,m);


    }
}