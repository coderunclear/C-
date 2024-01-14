using Calculator.Classes;
using System.Diagnostics;
bool still=true;
while (still)
{
Firstnum.Firstnumber();
Secondnum.Secondenumber();
OperatorCheck.OperatorChecker();  
Console.WriteLine("You still have questions?(y/n)");
string str1 =Console.ReadLine()??"";
string str  =str1.ToLower();
if (str=="y")
{
    Firstnum.FirstCheck=true;
    Secondnum.SecondCheck=true;
    OperatorCheck.OperatorCk=true;
    continue;
}else if(str=="n"){
    still=false;
}else{
    still=false;
}
}


