namespace Calculator.Classes
{
    public class OperatorCheck
    {
        public static bool OperatorCk=true;
        public static void OperatorChecker(){
         while (OperatorCk)
          {
              try
              {
              Console.WriteLine("What's your Operation ( + - / * )?");
              char OperatorChar =Convert.ToChar(Console.ReadLine()??"");
              OperatorCk=false;
              switch( OperatorChar) 
                  {
                    case '+':
                      Console.WriteLine($"Answer To Operation: {Mathes.Plus(Firstnum.Mynumber,Secondnum.Mynumber).ToString("0.00")}");
                      break;
                    case '-':
                      Console.WriteLine($"Answer To Operation: {Mathes.Minez(Firstnum.Mynumber,Secondnum.Mynumber).ToString("0.00")}");
                      break;
                    case '/':
                      Console.WriteLine($"Answer To Operation: {Mathes.Division(Firstnum.Mynumber,Secondnum.Mynumber).ToString("0.00")}");
                      break;
                    case '*':
                     Console.WriteLine($"Answer To Operation: {Mathes.multiplication(Firstnum.Mynumber,Secondnum.Mynumber).ToString("0.00")}");
                      break;
                    default:
                     Console.WriteLine("There is a problem with the math mark.");
                      OperatorCk=true;
                      break;
                  }
              }
              catch (Exception e)
              {
               Console.WriteLine($"Please Check Error: {e}");
              }  
          }
        }

    }
}