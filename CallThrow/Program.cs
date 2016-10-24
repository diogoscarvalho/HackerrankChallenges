using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(ts.Days + 1);
            Console.ReadKey();

            var somaA = 0;
            var somaB = 0;
            MyStruct a = new MyStruct();
            a.int2 = 2;
            a.int1 = 3;

            MyStruct b;
            b.int2 = 2;
            b.int1 = 5;

            Console.WriteLine("{0} e {1}", a.int1, a.int2);
            Console.ReadKey();
        }
    }
    public class MyClass :IDisposable
    {
        public virtual int MyProperty { get; set; }

        public static void ByRefTest(MyClass myClassRef)
        {
            myClassRef.MyProperty += 4;
        }

        public virtual void Dispose()
        {
            GC.Collect();
            GC.SuppressFinalize(this);
        }

        ~MyClass()
        {

        }
    }

    public struct MyStruct
    {
        public int int1;
        public int int2;

        public MyStruct(int pInt1, int pInt2)
        {
            int1 = pInt1;
            int2 = pInt2;
        }
    }

    public class MyClassChild : MyClass
    {
        
    }
}
