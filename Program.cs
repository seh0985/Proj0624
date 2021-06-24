using System;


namespace FirstProj
{
    class Program
    {
        
        static int numA = 99;

        string chA = "abcde";
        static void Main(string[] args)
        {
            Console.WriteLine("jaey!");
           // Console.WriteLine(numA);
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numA + i ) ;
           
            }
            */
            Program proA = new Program();
            proA.doThat();
        }

        void doThat()
        {
        Console.WriteLine(chA) ;          
        }
    }
}
