using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region Encapsulation
            //EmployeeDetail detail = new EmployeeDetail();
            //detail.set("Sayali");
            //Console.WriteLine("The employee details Name is: "+detail.get()); 
            #endregion

            #region Inheritence
            //Console.WriteLine("Creating object of base class");
            //BaseClass baseClass = new BaseClass();
            //baseClass.dataMamber = 4;
            //Console.WriteLine(baseClass.dataMamber);
            //baseClass.BaseClassMethod();

            //Console.WriteLine("Creating object of Derived class");
            //DerivedClass derived_Class = new DerivedClass();
            //Console.WriteLine(derived_Class.dataMamber);
            //derived_Class.BaseClassMethod();
            //derived_Class.derivedClassMethod();
            #endregion

            #region Extension methods

            #endregion
            Console.ReadKey();
        }
    }
    public class EmployeeDetail
    {
        private string Name;
        public string get()
        {
            return Name;
        }
        public void set(string name)
        {
            Name = name;
        }
    }

    public class BaseClass
    {
        public int dataMamber;
        public void BaseClassMethod()
        {
            Console.WriteLine("Base class method");
        }

    }
    public class DerivedClass : BaseClass
    {
        public void derivedClassMethod()
        {
            Console.WriteLine("DerivedClass method");
        }
    }

    public static class MyClass
    {

    }
}
