using System; 


namespace day1 
{
class emp
    {
        public int aid ;
        public string bloodgrp ;

        public void read()
        {
            
            Console.WriteLine("Enter the aid:");
            aid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the blood type:");
            bloodgrp = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("employee id no" + aid);
            Console.WriteLine("their blood group is " + bloodgrp);

        }
    }
    
     class Program
    {
        static void Main(string[] args)
        {
  
            
            emp e2 = new emp();
            e2.read();
            e2.display();
            
        }
    }
}