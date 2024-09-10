using System;
class Strings {
    static void Main() { 
    // In C# ALL STRINGS MUST USE DOUBLE-QUOTES " "

    string greeting = "Hello, how are you? Nice weather we got don't you think?\n";
    string goodbye = "See you later alligator.\n";

    // In C# strings are treated like an OBJECT that has properties and methods.
    // PROPERTIES -- things that describe the object such as length, values, data type, etc.
    // METHODS -- built in functions related to that object

    // Length is an important property for strings.
    Console.WriteLine(greeting.Length);
    Console.WriteLine(goodbye.Length);

    if (greetinf.Length > goodbye.Length);
    {
        Console.WriteLine("The greeting has more characters than goodbye");
    }
      // Usefull string methoods

      Console.WriteLine(greetingToUpper()); //Make entire string Upercase 
      Console.WriteLine(GreetingToLower()); //make entire sting lowercase

      //String Concatanation
      string comboString = greeting + goodbye; 
      Console.WriteLine(comboString)

      // String Concatenation methood #2 
      string comboString2 = string.Concat(greeting,goodbye);
      Console.WriteLine(comboString2); 

      String Interpolation -- Subtituting variables into strings
      string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}\n";
      Console.WriteLine(comboString3)


      // SUbsituting Vaiables into Strings methood 2 
      Conseole.WriteLine("My greeting is " + greeting + "and my goodbye is " + goodbye + ".\n");

      //Accessing parts of strings
      //Index is the spesefic location of a character in a strin
      //All string indexes start at 0  
      Console.WriteLine(Goodbye[0]); // Print character index at 0. 
      Console.WriteLine(Goodbye[4]); // replace x with what to print the 5th Char 

      // Where is it in my string 
      Console.WriteLine(greeting.IndexOf("y"));
      

    }

 }