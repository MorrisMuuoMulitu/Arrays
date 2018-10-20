using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          /* 
          int [] numbers=new int[5];
           numbers[0]=4;
            numbers[1]=8;
             numbers[2]=15;
              numbers[3]=16;
               numbers[4]=23;
                 numbers[5]=63;

               Console.WriteLine(numbers[2]);
               Console.WriteLine(numbers.Length);
               Console.ReadLine();*/ 
           
           
           int [] numbers=new int []{4,8,15,16,23,63};
           /* 
           for(int i=0;i<numbers.Length;i++)
           {
               Console.WriteLine(numbers[i]);
           }*/
           string[]names=new string[]{"Morris","King","Boss","Mathendu"};
           /* for(int i=0;i<names.Length;i++)
           {
               Console.WriteLine(names[i]);

           }
           Console.ReadLine();
            */
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


        }
    }
}
