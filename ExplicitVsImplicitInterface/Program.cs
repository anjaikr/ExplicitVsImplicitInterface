using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitVsImplicitInterface
{
    public abstract class A
    {

        private string data;

        protected A(string myString)
        {
            data = myString;
        }

    }

    public class B : A
    {

        public B(string myString) : base(myString)
        {
            Console.WriteLine("My String: {0}", myString);
        }

    }
    //interface Iinterface_1
    //{

    //}
    //class Class1 : Iinterface_1
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Class1 Display Method.");
    //    }
    //}

    //interface Iinterface_1
    //{
    //    void interface1_method();
    //}
    //interface Iinterface_2
    //{
    //    void interface2_method();
    //}

    //class Class1 : Iinterface_1, Iinterface_2

    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Class1 Display Method.");
    //        //Calling Implicit interface implementation
    //        interface1_method();

    //        //Call Explicit interface method
    //        Iinterface_1 obj_1 = new Class1();
    //        obj_1.interface1_method();
    //    }
    //    //Implicit interface implementation
    //    public void interface1_method()
    //    {
    //        Console.WriteLine("Iinterface_1 Method Implicit interface implementation.");
    //    }
    //    //Explicit interface implementation
    //    void Iinterface_1.interface1_method()
    //    {
    //        Console.WriteLine("Iinterface_1 Method Explicit interface implementation.");

    //    }

    //    public void interface2_method()
    //    {
    //        Console.WriteLine("Iinterface_2 Method.");
    //    }

    //}

    interface Iinterface_1
    {
        void interface1_method();
    }
    interface Iinterface_2 : Iinterface_1
    {
        void interface2_method();
    }

    class Class1 : Iinterface_2
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display Method.");
        }
        public void interface1_method()
        {
            Console.WriteLine("Iinterface_1 Method Implicit interface implementation.");
        }
        public void interface2_method()
        {
            Console.WriteLine("Iinterface_2 Method Implicit interface implementation.");
        }
        void Iinterface_1.interface1_method()
        {
            Console.WriteLine("Iinterface_1 Method Explicit interface implementation.");
        }
        void Iinterface_2.interface2_method()
        {
            Console.WriteLine("Iinterface_2 Method Explicit interface implementation.");
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Class1 objClass1 = new Class1();
            objClass1.Display();
            var objB = new B(@"mystring");
            //objClass1.interface1_method();
            //var objIiterface1 = (objClass1) as Iinterface_1;
            //objClass1.interface1_method();

            ////Call Explicit interface method
            //Iinterface_1 obj_1 = new Class1();
            //obj_1.interface1_method();

            //Iinterface_1 obj_1 = new Class1();
            //obj_1.interface1_method();
            //Iinterface_2 obj_2 = new Class1();
            //obj_2.interface2_method();
            objClass1.interface1_method();
            objClass1.interface2_method();

            Iinterface_2 obj_2 = new Class1();
            obj_2.interface1_method();
            obj_2.interface2_method();
            //Console.ReadLine();


            Console.ReadLine();
        }
    }

}
