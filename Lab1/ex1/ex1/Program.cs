using System;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
/////////////////////////////PrimeNumbers////////////////////////////////////////////////            
            // Console.WriteLine("PrimeNumbers: \n");
            // for (int i =2; i < 100; ++i)
            // {

            //     if (IsPrime(i) == true)
            //     {

            //         Console.WriteLine(i + " ");
            //     }
            //     else { continue; }
            // }
            // PrintFactorial(-1);
            // PrintFactorial(3);
            //  PrintFactorial(20);
            // PrintFactorial(10);
/////////////////////////////////////RightTriangle//////////////////////////////////////////////////
            RightTriangle myTringle = new RightTriangle();
            myTringle.A = 3;
            myTringle.B = 4;
            // Console.WriteLine("Obwod wynosi: "+ myTringle.Circumference);
            // Console.WriteLine("Sinus kata: " + myTringle.ComputeSine());
//////////////////////////////////////Album////////////////////////////////////////////////////////
            Album myAlbum =new Album();
            myAlbum.nameOfAlbum="Dark side of moon";
            myAlbum.nameOfArtist="Pink Floyd";
            myAlbum.nameOfDate =1972;
            myAlbum.nameOfTrack =9;

            Album myAlbum2 =new Album(){nameOfDate = 2000};
            Album myAlbum3 =new Album("Złoty Paw", 2000);
            Album myAlbum4 =new Album(2);


            // myAlbum.ShowAlbumInfo();
            // myAlbum2.ShowAlbumInfo();
            // myAlbum3.ShowAlbumInfo();
            // myAlbum4.ShowAlbumInfo();
            //Console.WriteLine("Number of albums: "+Album.HowManyAlbums());
            Album.ClearAlbumCounter();
            //Console.WriteLine("Clear all albums " +Album.HowManyAlbums());
////////////////////////////////////TABLE////////////////////////////////////////////////////////  
             int counter =0;          
            // string[] myTab= {"aa","bb","cc","dd","ee"};
            // for(int i =0; i<myTab.Length;++i){
            //     Console.WriteLine("Element "+i+" wynosi "+myTab[i]);
            // }

            // foreach(string elems in myTab){
            //     counter++;
            //     Console.WriteLine($"Element #{counter}: {elems}");
            // }

            List <string> myList = new List<string>{
                "AA",
                "cgsua",
                "DDD",
                "DFFFSA",
            };
            myList.Add("MAMA");
            myList.Insert(2,"TATA");
            Console.WriteLine(myList.IndexOf("TATA"));

            for(int i =0; i<myList.Count;++i){
                Console.WriteLine("Element "+i+" wynosi "+myList[i]);
            }

            foreach(string elems in myList){
                counter++;
                Console.WriteLine($"Element #{counter}: {elems}");
            }


            Console.WriteLine();
            Console.ReadKey();

        }

        static double Pythagoras(double a, double b)
        {
            double result;
            result = Math.Sqrt(a * a + b * b);
            return result;
        }

        static bool IsPrime(int a)
        {
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
               
            }
            return true;
        }

        static void PrintFactorial(int a)
        {
            if (a<0){Console.WriteLine("Error! Cannnot compute factorial of negative number...");}
            else {Console.WriteLine("Factorial of "+a+" is equal to: "+Factorial(a));}
        }
        static long Factorial(int a){
            if (a <= 1) { return 1; }
            else{return a * Factorial(a - 1); }
        }
    }
}
