using System;
using System.Linq;
using System.Collections.Generic;
 
class LinqExercise5
{
    static void Main(string[] args)
    {
      string str; 

            Console.Write("LINQ : Display the characters and frequency of character from giving string : ");	
            Console.Write("Input the string : ");
            str= Console.ReadLine();
            Console.Write("\n");
        
            var FreQ = from x in str  
                    group x by x into y  
                    select y;  
                Console.Write("The frequency of the characters are :\n");
                foreach(var ArrEle in FreQ)  
                    {  
                    Console.WriteLine("Character "+ArrEle.Key + ": " + ArrEle.Count()+" times");  
                    }  
    }
}


// outputt
LINQ : Display the characters and frequency of character from giving string : 
Input the string : successs
The frequency of the characters are :
Character s: 3 times
Character u: 1 times
Character c: 2 times
Character e: 1 times
