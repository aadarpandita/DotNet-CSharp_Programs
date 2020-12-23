using System;
namespace swap {
    
    class Overloading {

        void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        void swap(ref float a, ref float b) {
            float temp = a;
            a = b;
            b = temp;
        }
        
        static void Main(string[] args) {
            
            Overloading p = new Overloading();
            
            int a = 15, b = 20;
            
            Console.WriteLine($"Integers before swapping : {a}, {b}");  
            p.swap(a: ref a,b: ref b);            
            Console.WriteLine($"Integers after swapping : {a}, {b}");            
            float c = 15.2f, d = 13.8f;
            
            Console.WriteLine($"Float numbers before swapping : {c}, {d}");            
            p.swap(ref c, ref d);            
            Console.WriteLine($"Float numbers after swapping : {c}, {d}");
        }
    }    
}
