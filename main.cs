using System;
using System.Linq;

class MainClass
{
  public static void Main (string[] args) 
  {

    
    int[] numbers = new int[10];  
    int[] OddNum = new int[10];
    int OddCounter = 0;  
    int[] EvenNum = new int[10];
    int EvenCounter = 0;
    
    

    for(int i=0; i<numbers.Length; i++)    
    {     
      
      Console.WriteLine("Enter a number");
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    for(int i=0; i<numbers.Length; i++)
    {
      int remainder = numbers[i] % 2;

      if(remainder == 1)
        {
          OddNum[i] = numbers[i];
          OddCounter++;
        }
      else
        {
          EvenNum[i] = numbers[i];
          EvenCounter++;
        }
      
    }
      Array.Sort(OddNum);
      Array.Reverse(OddNum);
      Console.WriteLine("Here are the odd numbers in descending order");      
      foreach(int x in OddNum)        
        {           
          if(x != 0)
          Console.WriteLine(x);
        }
        
      Array.Sort(EvenNum);
      Console.WriteLine("Here are the even numbers in ascending order");      
      foreach(int y in EvenNum)        
        {          
          if(y != 0)
          Console.WriteLine(y);
        }
        

      Console.WriteLine("Here is the Sum of odd numbers");
      Console.WriteLine(OddNum.Sum());  

      Console.WriteLine("Here is the Sum of even numbers");
      Console.WriteLine(EvenNum.Sum());

   
  }
}