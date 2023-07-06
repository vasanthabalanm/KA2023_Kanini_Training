using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    public class Execute
    {
        public static void Main(String[] args)
        {
            //1.
            //QueSol quadrnt = new QueSol();
            //quadrnt.quad();

            //2.
            //QueSol rnk = new QueSol();
            //rnk.rank();

            //3.
            //QueSol elcty = new QueSol();
            //elcty.electricity();

            //4.a
            //QueSol rgt1 = new QueSol();
            //rgt1.right1();

            //4.b
            //QueSol rgt2 = new QueSol();
            //rgt2.right2();

            //5.a-f
            //QueSol quesA = new QueSol();
            //quesA.QuestA();

            //6
            //QueSol trans = new QueSol();
            //trans.transpose();

            //7.
            //QueSol prme = new QueSol();
            //prme.PrimeSum();

            //8.
            //QueSol cuntstr = new QueSol();
            //cuntstr.CountString();

            //9.
            //QueSol allcount = new QueSol();
            //allcount.AllinOne();

            //11.
            //QueSol fibo = new QueSol();
            //Console.WriteLine("enter the limit:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //fibo.fiboseries(n);

            //12.
            //QueSol ms = new QueSol();
            //Console.WriteLine("enter the number to check armstrong or not:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //ms.arms(num);

            //14.
            //QueSol prm = new QueSol();
            //Console.WriteLine("Enter the number to check prime or not:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //prm.primeNumbers(num);

            //15a.
            //QueSol strpalind = new QueSol();
            //Console.WriteLine("Enter the string to check palindrome or not");
            //String word = Console.ReadLine();
            //strpalind.strpalindrome(word);

            //15b.
            QueSol numpali = new QueSol();
            Console.WriteLine("Enter the number to check palindrome or not:");
            int num = Convert.ToInt32(Console.ReadLine());
            numpali.numpalindrome(num);


        }
    }
}
