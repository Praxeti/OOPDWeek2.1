using System;

namespace OOPDWeek2
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Creating an instance of parent");
        }
        
        public void Print()
        {
            Console.WriteLine("I am a parent!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }


    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Creating an instance of child");
        }

        public void Print()
        {
            Console.WriteLine("I am a child!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {   
            ParentClass parent = new ParentClass();
            ChildClass child = new ChildClass();

            parent.Print();
            child.SayHello();
        }
    }
}
