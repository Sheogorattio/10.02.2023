using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonClass
{
    public class Comparison
    {
        private int num1, num2=0, signIndex=0;
        private string sign;
       // private string expression;
        public Comparison(string expression)
        {
            try
            {
                for (int i = 0; i < expression.Length; i++)
                {
                    if (!((expression[i] >= 48 && expression[i] <= 57) || (expression[i] >= 60 && expression[i] <= 62) || expression[i] == 33))
                        throw new Exception("Input error");
                    if (!(expression[i] >= 48 && expression[i] <= 57) && ((expression[i] >= 60 && expression[i] <= 62) || expression[i] == 33))
                    {
                        if(signIndex == 0)signIndex = i;
                        sign += expression[i];
                    }
                    
                   
               
                }
                num1 = Convert.ToInt32(expression.Substring(0, signIndex));             
                num2 = Convert.ToInt32(expression.Substring(signIndex + sign.Length));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(1);
            }
        }

        public bool GetResult()
        {
            switch (sign)
            {
                case ">":
                    return num1>num2;
                    
                case "<":
                    return num1 < num2;
                    
                case ">=":
                    return num1 >= num2;
                    
                case "<=":
                    return num1<=num2;
                    
                case "==":
                    return num1 == num2;
                    
                case "!=":
                    return num1 != num2;
                    
                default:
                    return false;
            }
        }

       
    }
}
