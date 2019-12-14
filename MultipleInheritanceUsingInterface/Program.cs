using System;

namespace MultipleInheritanceUsingInterface
{
    //example 1
    public interface Interface1
    {
        void Test();
        void Show();
    }
    public interface Interface2
    {
        void Test();
        void Show();
    }
    class ImplementInterafce : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Test method is implemented");
        }
        public void Show()
        {
            Console.WriteLine("Show mwthod is implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInterafce obj = new ImplementInterafce();
            obj.Test();
            obj.Show();
            Interface1 obj1 = new ImplementInterafce();
            obj1.Test();
            obj1.Show();
            Interface2 obj2 = new ImplementInterafce();
            obj2.Test();
            obj2.Show();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }

}
