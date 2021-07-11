using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

    
    int[] numbers = new int[3];  
    int[] OddNum = new int[3];
    int OddCounter = 0;  
    int[] EvenNum = new int[3];
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
          OddNum[0] = numbers[i];
          OddCounter++;
        }
      else
        {
          EvenNum[0] = numbers[i];
          EvenCounter++;
         }

    //Array.Sort(OddNum);
    foreach(int x in OddNum)
      {
      Console.WriteLine(x);
      }
    }
   }
}