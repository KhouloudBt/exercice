using System;

namespace second
{
    class Program
    {

        static bool Search(int[] L, int x)
        {
            int i = 0;

            while (true && (i < 7))
            {
                if (L[i] == x)  return  true;
                else i++;
            }

            return false ;
        }

        static void affichage(int[] tab, int N)
        {
            int i;
            for (i = 0; i < N; i++)
            {
                Console.Write(tab[i] + "\n");

            }

        }
        static void remplir(int[] tab, int N)
        {
            Random rnd = new Random();
            tab[0] = rnd.Next(1, 49);
            int x;
            int i = 1;

            do
            {
                x = rnd.Next(1, 49);
                if ((!Search(tab, x))) { tab[i] = x; i++; }
            } while (i < N);

        }
        static void Main(string[] args)
        {
            int[] tab = new int[7];
            remplir(tab, 7);
            affichage(tab, 7);

            /*     int y;
                  Random rnd = new Random();
                   int x=rnd.Next(1,50) ;

             int counter=1;
             int max =10;
           Console.Write("Entrer un entier ");
           y = int.Parse(Console.ReadLine());
         if(x==y)Console.Write("Congrats u won from the first essay ! ");
      else 
   { 


  while ((x != y ) && ( counter < max))
  {
      if (x > y) Console.Write("Enter a lower number ");
   if (x<y) Console.Write("enter a higher number ");
  Console.Write("Entrer un entier ");
   y = int.Parse(Console.ReadLine());

  counter++;
  }
   }

  if( x==y)
   {
       Console.Write(" U won in"+counter+"essays ! ");

   }
   else Console.Write(" you failed :( ");
  */




        }
    }
}

