using System; 

namespace aula02 
{
    class Program 
    {
        static void Main(string[] args)
        {
            if(args.GetValue(0).ToString() == "red"){
                Console.Write("is red");
                return;
            }

            Console.Write("is not red");

        }
    }
}

 