
{


//Data Types and Operators, Ross Kentrell, 0v.0
using System;

class DataTypesOperators; {
  static void Main(); {
    //This is a comment, it gets ignored
    
   
   // this is still a comment
    
    //DATA TYPES
    // C# is statically typed -- Once a variable has a data type, it cannot change.

    //FLoat - float --  decimal numbers, including +/- including 0.0

    //Double - double -- decimal numbers, including +/- including 0.0 <-- Most commonly used Decimal 

    // Integers -- int -- whole numbers, +/- including 0 

    //Variables are 'Buckets' with a name to store data inside 

    // Declaring (Creating Variables)
    // Methood #1 Declared byt not assign ( DataaType variableName)

    int myInteger;
    double myDouble

    // Methood #2 -- Declare AND assign 
    int myInteger2; = 1;
    double myDouble2 = 2.05D;

    // Strings -- Collections of letters, numbers, special characters
    string myString = "The man behind the slaughter.";

    //Booleans -- bool True or False values
    bool myBool = true;
    bool isChild = false;
    bool night = true; 

    //Char -- char -- a single character
    myChar = 'E'; 

    // Assigning values after Declaration

    myInteger = 5; 
    myBool night = false;
    string myString = "I always come back.";

    //Printing variables to the console terminal
    Console.WriteLine(myInteger);
    Console.WriteLine(myDouble);

    Console.WriteLine(myInteger-25);
    Console.WriteLine(myDouble +2.0D);

    Console.WriteLine(myInteger);
    Console.WriteLine(myDouble);

    // Oportators --Arthimetic
    // addistion 
  
    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;

    double myNewNumber = myInteger + myDouble; 

    // Subtracton
     myNewNumber = myDouble - myInteger;

    //Division 
     myNewNumber = myDouble / myInteger;

    //Multipulcation 
     myNewNumber = myDouble * myInteger;

     // Modulus -- Divides, then returns the remainder
     // most commonly used to describe even or odd
     myNewNumber = myDouble % 2; 

     int students = 6;
     int numSlices = 35;
     int Leftovers; 

     Leftovers = numSlices % students;   

     //Incremement / Decrement  -- Most frequesntly used in loops 
     x = 0;
     x++ // what is X equal to now
     //Incremebt ++ ADDS one to the current value into the bucket
     x--; 
     // Decrement -- subtracts 1 from the current value annd puts the new value into the bucket

     // Special assignmrnt operators

     x += 1;
     x *= 1;
     x /= 1;
     x -= 1;
     x %= 1;
     //Take current value, perform the calculation, put value into bucket 

     // Comparison operators
     //Evaluate the expresion, return true OR fLW

     int y = 5;
     int z = 3;

     //is equal == is the value om the left equal to the right
     Console.WriteLine(y==z); 

     // NOT equal to != is the value on the left not equal to the rigt
      Console.WriteLine(y==z); 
      
     //Greater than
      Console.WriteLine(y>z); 

     //Greater than or equal too >=
      Console.WriteLine(y>=z); 

      // Less than < 
      Console.WriteLine(y<z);

      //Less than or equal to <=
      Console.WriteLine(y<=z); 

      // Logical Operators
      int b = 1; 
      double c =2.0D;
      string favColor ="Blue"
      //Logicall and && -- all statements must be true
      // Console.WriteLine(b > 1 && c != 5.0D); // False because B is not > 1
      // Console.WriteLine(b == 1 && c < 10.0D); // True because both are right 
      // //If one expression is most likely to be False, check for it FIRST
      // Console.WriteLine(hasPurpleKey == true && playerLevel > 5);

      // // Logical OR ||
      // Console.WriteLine(b > 1 || c != 5.0D); // True because c is != 5.0D
      // Console.WriteLine(b == 2 || c > 10.0D); // False because both are wrong
      // //If one expression is most likely to be true check for it FIRST 
      // Console.WriteLine(hasBlueKey == true && playerLevel > 3);

      // Logical NOT ! -- returns the opposite value 
      Console.WriteLine(b>-1) //True
       Console.WriteLine(!(b>-1)) //False

      //console.Writeline ("What is your player name? type it and press ENTER .\n")

      // Create a variable to store DATA
      string playernName = Console.ReadLine();
      // Console.ReadLine() ONLY RETURNS string data types
      Console.WriteLine("What is your age ?  Type it and press ENTER.\n");
      string age = Console.ReadLine();
      Console.WriteLine (age + age);
      // Adding sting data types together is alled concatenation

      // print the variable to the screen
      //Console.WriteLine( "Your player name is" + playerName);

      //Inputting numbers from the console.
      Console.WriteLine("How many chicken nuggues can you eat in 5 minutes? Enter an integer value and press enter.\n")
      int numNuggies = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(numNuggies - + numNuggies);

      int Day = 1;
      switch(day)
      {
         case 1:
              Console.WriteLine("Its Monday.\n") 
                break;
              case 2:
              Console.WriteLine("Its Tuesday.\n")
                break; 
              case 3:
              Console.WriteLine("Its Wednesday.\n")
                break; 
              // case 4-6:
              case 7:
              Console.WriteLine("Its Sunday, go rest.\n") 
                break;


      } 
      //Repeating steps over and over
      //Loops are used to repeat repeat intructions multiple times

      //While loops are "musical chairs" in computer science
      //use if yoy dont know how many loops you'll need 
      //the code will run as long as the conndition is true 
      // while in loop syntax:
      /*

      while (Conditional_Expression)
      {
              Code to loop goes here
      }
       */

       int z == 0;
       while(z <= 100) // what do i replace contidional expression with?
       {
        Console.WriteLine(z);
        z++;
       }

       int y == 100;
       while(y <= 0) // what do i replace contidional expression with?
       {
        Console.WriteLine(z);
        y--;

        // for loops are like playing go fish
        // you know many cards in your hand
        // used when you know how many loops ahead of time

        /* 
        for ( statement1; statement2; statement3)
        {
          code to run each through loop
        }

       } 

       Statement1 = one time before the loop starts.
       Statement2 = Condidtional expression, check each time before loop ends
       statement3 = code to run after each loop

       Each time the loop runs its called an iteration 

       */

       for (int i = 0; i <= 10; i++)
       {
        console.WriteLine(i)
       }

        for (int i = 10; i <= 0; i--)
       {
        console.WriteLine(i)
       }

       // TEST


    

}