using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
              System.Console.WriteLine("Enter the first number: ");
            string num1 = Console.ReadLine();
            System.Console.WriteLine("Enter the second number: ");
            string num2 = Console.ReadLine();
            
            System.Console.WriteLine(mulnums(num1,num2));
        }

        static string mulnums(string x, string y){
             //int x = Convert.ToInt32(num1);
            
           string z="";
            int product=0;
            int len1 = x.Length;
            int len2 = y.Length;
            int carry=0;
            while(len1 >= 1 || len2 >= 1){
                int i=0,j = 0;
                if (len1 >0){
                     i=x[len1-1]-'0';
                    System.Console.WriteLine(i);
                        len1--;
                }
                if(len2 > 0){
                    j = y[len2-1]-'0';
                    System.Console.WriteLine(j);
                    len2--;
                }
               
                product = i * j;
               
            
                if (product >= 10){   
                    product = product % 10;
                    // product = product / 10;
                    carry=1;
                    System.Console.WriteLine("carry "+ carry);
                    System.Console.WriteLine("product " + product);
                }
                else{
                    carry = 0;
                    product=product%1;
                     System.Console.WriteLine("product " + product);
                }
                
                z=Convert.ToString(product)+z;

          
            }
            //  if(carry==1){
                    
            //           z="1"+z;
                   

            //     }
                
            return z;
            
          
           
        }
    }
}
