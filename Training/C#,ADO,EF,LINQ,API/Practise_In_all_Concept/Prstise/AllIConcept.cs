using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    internal class AllIConcept
    {
        //single inheritance
        //heirarchial inheritance
        //multilevel inheritance


        //hybrid inheritance 

        //multiple inheirtance = using interface can deploy possible
    }

    //single inheritance..
    class base01
    {

        public int i;
        void disp()
        {
            Console.WriteLine(i);
        }
        //protected int j=20;
        public void f1() { Console.WriteLine("f1 in base"); }
        public virtual void f2() { Console.WriteLine("vrtual in f2 base"); }
        public virtual void f3() { Console.WriteLine("vrtual f3 in base"); }
        /*public base012() 
        {
            Console.WriteLine("sample");
        }*/
        public virtual void bse()
        {
            Console.WriteLine("This is base class");
        }
    }
    class child01:base01
    {
        public int j;
        public void disp()
        {
            Console.WriteLine(j);
        }
        //int j=10;
        new public void f1() { Console.WriteLine("new in f1 derived"); }    
        public override void f2() { Console.WriteLine("override f2 in derived"); }
        public new void f3() { Console.WriteLine("new void f3 in derived"); }
        /*public void dp()
        {
            Console.WriteLine(j + " "+base.j);
        }*/
        public void display()
        {
            //base.j = 3;
            Console.WriteLine(j + "" + j);
        }
       public override void  bse()
        {
            Console.WriteLine("This is base class from same meathod in child class virtual and override concept");
        }
        public void chld01()
        {
            Console.WriteLine("this is Child class01 in single inheritance concept");
        }
        public child01()
        {
            Console.WriteLine("this is copy constructor");
        }
    }
    //heirarchial inheritance..
    class child02 : base01
    {
        public void chld02()
        {
            Console.WriteLine("this is chld02 class in heiracrchial concept");
        }
    }

    //multilevel inheritance
    class child03 : base01
    {
        public void chld03()
        {
            Console.WriteLine("this is chld03 class in multilevel concept base as consider base01 class");
        }
    }
    class subchilclass03 : child03
    {
        public void subclass03()
        {
            Console.WriteLine("this is subchilclassd03 class in base as child2");
        }
    }

    //hybrid inheritance 
    class subchilclass04 : child03
    {
        public void subclass03()
        {
            Console.WriteLine("this is subchilclassd03 class in base as child2");
        }
    }
    class subchilclass041 : subchilclass04
    {
        public void subchild41()
        {
            Console.WriteLine("this is a chld of subclass4");
        }
    }
    class subchilclass0411 : subchilclass041
    {
        public void subcld411()
        {
            Console.WriteLine("this is child of subchilclass041");
        }
    }

    //multiple inheritance
    //interface concept  has been use here
    interface child04
    {
        /*string str1 { get; set; }
        string str2 { get; set; }
        void print();
        void stock();
        int fun();*/
        //only meathod declaration
        public void meathod1();

        public void abc()
        {
            Console.Write("this is sample");
        }
    }
    class child05:child04
    {
        //should be implement meathod in interface name
        public void meathod1()
        {
            Console.WriteLine("this is from interface");
        }
    }
    abstract class child06
    {
        public abstract void mtd12();

        public void sample()
        {
            Console.WriteLine("this is sample abstarct meathod");
        }
    }
    class chil07:child06
    {
        public override void mtd12()
        {
            Console.WriteLine("ok done");
        }
    }



}
