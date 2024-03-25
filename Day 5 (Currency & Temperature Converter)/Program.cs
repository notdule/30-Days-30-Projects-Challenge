static void Main(string[] args)
{
    Console.WriteLine("Welcome! Please enter 'c' to use the currency converter or anything else for the temperature converter.");
    string answer = Console.ReadLine();
 
    if(answer == "c")
    {
        Console.WriteLine("You have selected the currency converter.");
        Console.WriteLine("Please enter 'a' to convert from pounds or anything to convert from euros.");
        string choice = Console.ReadLine();
 
        if(choice == "a")
        {
            Console.WriteLine("Please enter an amount in British pounds.");
            float pounds = float.Parse(Console.ReadLine());
 
            float euros = pounds * 1.16f;
            Console.WriteLine("The amount in euros is " + euros.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("Please enter the amount in euros.");
            float euros = float.Parse(Console.ReadLine());
 
            float pounds = euros / 1.16f;
            Console.WriteLine("The amount in pounds is " + pounds.ToString("0.00"));
        }
 
    }
    else
    {
        Console.WriteLine("Welcome to the temperature converter!");
        Console.WriteLine("Please enter 'a' to convert from celcius or anything else to convert from fahrenheit.");
        string choice = Console.ReadLine();
 
        if (choice == "a")
        {
            Console.WriteLine("Enter a temperature in celcius.");
            float celcuis = float.Parse(Console.ReadLine());
 
            float fahrenheit = celcuis * 1.8f + 32f;
            Console.WriteLine("The amount in fahrenheit is " + fahrenheit);
        }
        else
        {
            Console.WriteLine("Please enter the temperature in fahrenheit.");
            float fahrenheit = float.Parse(Console.ReadLine());
 
            float celcuis = (fahrenheit - 32f) / 1.8f;
            Console.WriteLine("The temperature in celcuis is " + celcuis);
        }
    }
 
}
