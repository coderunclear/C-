namespace Calculator.Classes
{
    public class Mathes
    {
        public static double Plus(double num1,double num2){
            return (num1+=num2);
        }
         public static double Minez(double num1,double num2){
            return (num1-=num2);
        }
         public static double Division(double num1,double num2){
            return (num1/=num2);
        }
         public static double multiplication(double num1,double num2){
            return (num1*=num2);
        }
    }
}