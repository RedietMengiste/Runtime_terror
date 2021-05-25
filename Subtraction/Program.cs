using System;

namespace Subtraction
{
    class Program
    {
        static void Main(String[] args) {
		 
            System.Console.WriteLine("Enter the first number: ");
            string num1 = Console.ReadLine();
            System.Console.WriteLine("Enter the second number: ");
            string num2 = Console.ReadLine();
            
            System.Console.WriteLine(subnums(num1,num2));
		
	}
 
	  static string subnums(string x, string y){
             //int x = Convert.ToInt32(num1);
            
           string z="";
            int diff=0;
            int len1 = x.Length;
            int len2 = y.Length;
            int borrow=0;
            if(Convert.ToInt32(x) > Convert.ToInt32(y)){
            while(len1 >= 1 || len2 >= 1){
				
                int i=0,j = 0;
                if (len1 >0){
                    
					 if(borrow==1){
						i=x[len1-1]-'0'-1;
						// borrow = 0;
						len1--;
					 }
					else{
						i=x[len1-1]-'0';
						borrow=0;
						len1--;
					}
					//System.Console.WriteLine(i);
						
                }
				
               if(len2 > 0){
                j = y[len2-1]-'0';
                //System.Console.WriteLine(j);
                len2--;
               }
			  
				
               if (i<j){
                diff = (i+10) - j ;
				borrow = 1;
				
				// j = (y[len2-1]-'0')-1;
			   }
				else
				    diff=i-j;
					
                
				//System.Console.WriteLine("borrow "+borrow);
            
                // z=Convert.ToString(diff);
                z=Convert.ToString(diff)+z;

          
            }
			 
            }
            else{
                string temp = x;
                 x=y;
                 y=temp;
                 System.Console.WriteLine("-"+subnums(x,y));
            }
               
            return z;
            
        //   return null;
           
        }
 

}
}
