using System; 
 
public class ConvertDigitsToWords
{   
  public static void Main()
  { 
    int num; 
    int nextdigit; 
    int numdigits; 
    int[] n = new int[20]; 
 
    string[] digits = { "zero", "one", "two", 
                        "three", "four", "five", 
                        "six", "seven", "eight", 
                        "nine" }; 
 
 
    Console.WriteLine("Enter the number");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number: " + num); 
    Console.Write("Number in words: ");    
    nextdigit = 0; 
    numdigits = 0;
    do 
    { 
      nextdigit = num % 10; 
      n[numdigits] = nextdigit; 
      numdigits++; 
      num = num / 10; 
    } while(num > 0); 
    numdigits--; 
    for( ; numdigits >= 0; numdigits--) 
        Console.Write(digits[n[numdigits]] + " "); 
    Console.WriteLine();
    Console.ReadLine();
  }   
}
