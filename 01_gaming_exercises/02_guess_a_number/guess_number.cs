using System;
class guessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 3;
    int guess; 

    // Generate a secret number here
    Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the Random() class.
    int secretNumber = rnd.Next(70); // generate from 0 to 69
    //console.WriteLine(secretNumber) //Comment out after testing
    //int secretNumber = rnd.Next(25,1000); generate from, 25 to 999

    while(numGuess < maxGuess) 
    {
        Console.WriteLine("Please guess an integer between 0 and 69\n"); 
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(guess);

        numGuess++;
        if (guess < secretNumber)
        {
            Console.WriteLine("Your guess is to low!\n");
        }
        else if (guess > secretNumber)
        {
           Console.WriteLine("Your guess is to High!\n");
        }
        else
        {
            Console.WriteLine("Correct!\n");
            break; //keyword to immedeantly exit loops
        }

        if (numGuess >= maxGuess)
        {
            Console.WriteLine("You lost the game. \n your punishment has been determined, to the elecric chair with you\n");
        }
    }
      // allow the user to guess the number 
      //Compare the guess to the secret number 
      // If match print win, if > or < give a hint
      //+1 to numGuess
      //Check if numguess > maxGuess
      // if true print a lose game message if false guess again 


  }

}