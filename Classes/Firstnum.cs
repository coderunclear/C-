namespace Calculator.Classes
{
    public class Firstnum
    {
        public static double Mynumber { get; set; }
        public static bool FirstCheck=true;
        public static  void Firstnumber(){
            while (FirstCheck)
            {
              try
                {
                Console.WriteLine("What's your First Number?");
                Mynumber =Convert.ToDouble(Console.ReadLine());
                FirstCheck=false;
                }
                catch (Exception e)
                {
                 Console.WriteLine($"Please Check Error: {e}");
                }  
            }
        }
    }
}