using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intcldll;

namespace Access_Specifier
{
    class One
    {
        public int x;
        protected int a;
        private int y;
        protected internal string name;


        public void Dispaly1()
        {
            Console.WriteLine("Public Function");
        }
        private void Display2()
        {
            Console.WriteLine("Private Function");
        }
        protected void Dispaly3()
        {
            Console.WriteLine("Protected Member:{0}", a);
        }
        internal void Display4()
        {
            Console.WriteLine("Internal Member in same assembly");
        }
        protected internal void Dispaly5()
        {
            Console.WriteLine("Protected Internal Member",name);
        }

    }
    class Program:One
    {
        static void Main(string[] args)
        {
            One o = new One();
            o.Dispaly1();
            //o.Dispaly2();     // Can not access private member
            Program p = new Program();
            p.a = 100;          // derived class object for proteced
            p.Dispaly3();

            o.Display4();       //internal within same assembly

            o.name = "Sudha";   //Protected internal
            o.Dispaly5();

            Class1 c = new Class1();
            c.Disp();           //internal mb in other assembly should b public

             c.Displ();
            //c.x = 10;  
            c.Fun();
            Console.ReadLine();
        }
    }
}
