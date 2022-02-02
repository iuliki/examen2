using System;

namespace examen2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 67;
                 char letter = (char)number;
            Console.WriteLine("the letter is: " + letter);
            Console.WriteLine("the number is: " + number);
            Console.WriteLine();
            Console.WriteLine("aici incepe rezolvarea simularii pentru examen");
            Console.WriteLine();

            Console.WriteLine("Introduce textul: ");

            string text;
            text = Console.ReadLine(); 
            Print(text);

            Console.WriteLine("exista 4 reguli prin care poti modifica textul. alege varianta ta");
           

           //var a
            ReplaceSubString(text);
            Console.WriteLine();
           //var b
            RemoveSubString(text);
            //var c
            InsertingANewString(text);
            //var d 
            ToUpper(text);
            //var e
            ToLower(text);




          //  Console.WriteLine(Factorial(4));
   

        }

       /* public static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
       */
      

        static void Print(string text)
        {
            string parameterName = nameof(text);
            if (text is null)
                Console.WriteLine("the parameter is null");
            else
                Console.WriteLine("textul meu este " + text);

        }

        static void ReplaceSubString(string text)
        {
            Console.WriteLine("textul cu care vrei sa inlocuiesti textul dat este: ");
            string newText;
            newText = Console.ReadLine();

            string parameterName = nameof(newText);
            if (newText is null)
                Console.WriteLine("the new text  is null so we can't change the text");
            else
            {   
                Console.WriteLine("textul pe care vreau sa l inlocuiesc este " );
                string T1;
                T1 = Console.ReadLine(); 

                var replacement = text.Replace(T1,newText);
                Console.WriteLine(text);
                Console.WriteLine(replacement); 

                
            }

        }

        static void RemoveSubString(string text)
        {
            Console.WriteLine("textul care vrei sa dispara este: ");
            string newText;
            newText = Console.ReadLine();

            string parameterName = nameof(newText);
            if (newText is null)
                Console.WriteLine("the new text  is null so we can't change the text");
            else
            {     
                 string toRemove = newText;
                 string result = string.Empty;
                 int i = text.IndexOf(toRemove);
                 if (i >= 0)
                 {
                     newText = text.Remove(i, toRemove.Length);
                 }
                 Console.WriteLine(text);
                 Console.WriteLine(newText);}
            
        }

        static void InsertingANewString(string text)
        {
            Console.WriteLine("Indexul unde vreau sa pun sirul nou este: ");
            int nr;

            nr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("textul pe care vreau sa l adaug este:  ");
            string newText;
            newText = Console.ReadLine();

            Console.WriteLine("New string: " + text.Insert(nr, newText));
        }

        static void ToUpper(string text)
        {
            string  upperText = text.ToUpper();

            Console.WriteLine(upperText);
        }

        static void ToLower(string text)
        {
            string lowerText = text.ToLower();

            Console.WriteLine(lowerText);
        }


    }
}
