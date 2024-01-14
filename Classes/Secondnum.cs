namespace Calculator.Classes
{
    public class Secondnum
    {
         public static double Mynumber { get; set; }
        public static bool SecondCheck=true;
        public static void Secondenumber(){
            while (SecondCheck)
            {
                try
                {
                Console.WriteLine("What's your Seconde Number?");
                Mynumber =Convert.ToDouble(Console.ReadLine());
                SecondCheck=false;
                }
                catch (Exception e)
                {
                 Console.WriteLine($"Please Check Error: {e}");
                }  
            }
        }

    }
}