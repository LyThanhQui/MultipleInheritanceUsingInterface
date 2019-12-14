using System;

namespace MultipleInheritanceUsingInterface
{
    //example 1
    /*  public interface Interface1
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
      }*/

    //example 2
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
        //public modifier is not allowed 
        void Interface1.Test()
        {
            Console.WriteLine("Test mthod of interafce1 is implemented");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Show mwthod of interafce1 is implemented");
        }
        void Interface2.Test()
        {
            Console.WriteLine("Test mthod of interface2 is implemented");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Show mwthod of interafce2 is implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInterafce obj = new ImplementInterafce();
            //obj.Test();  //not possible
            //obj.Show();  //not possible
            ((Interface1)obj).Test();
            ((Interface1)obj).Show();
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
