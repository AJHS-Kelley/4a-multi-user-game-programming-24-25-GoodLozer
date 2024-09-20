using System;
class rps {
     static void Main(){

        ///PlayerVariables
        
      string playerName = "Test Player"; 
      int playerScore = 0; 
      string playerChoice "";

      //Cpu variables

      int cpuScore = 0;
      string cpuChoice "";

      Console.WriteLine("Welclcome to rock paper scissors! Please, tell me your name and hit ENTER.\n");      
      playerName = Console.ReadLine(); 
      Console.WriteLine($"Your name is\n" + playerName"?\n");
      Console.WriteLine("please type yes or no, then press ener to confirm.\n");
      string isCorrect = Console.ReadLine().ToLower();

        if(isCorrect == "yes")
        {
           Console.WriteLine($"Great! I'll call you {playerName}.\n";)
        } 
        else if (isCorrect == "no")
        {
            Console.WriteLine("Welclcome to rock paper scissors! Please, tell me your name and hit ENTER.\n");      
      playerName = Console.ReadLine(); 
        }

      Console.WriteLine("The rules are simple! First to 5 points wins! Each vicotry adds 1 point!\n");
      Console.WriteLine("rock beats scissors. paper beats rock. scissors beats paper!\n"); 

      while (playerScore < 5 && cpuScore < 5)
      {
        
        //Print the scores
        Console.WriteLine($"Your score; {playerScore}\n CPU Score: {cpuScore}\n");
        //Allow player to select r p s
        Console.WriteLine("Please Choose rock paper or scissors. Type your awnser and press enter");
        playerChoice = Console.ReadLine().ToLower();
        if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
        {
            Console.WriteLine("Please Choose rock paper or scissors. Type your awnser and press enter");
        playerChoice = Console.ReadLine().ToLower();
        }
        //Allow cpu to sellect randomly
        Random rnd = new Random ();
        int cpuRand = rnd.Next(0,2);

        if (cpuRand == 0)
        {
            cpuChoice = "rock"
        }
        else if (cpuRand = 1)
        {
            cpuChoice = "paper"
        }
        else if (cpuRand = 2)
        {
            cpuChoice = "scissors"
        }
        else
        {
            Console.WriteLine("Unable to determine cpu choice\n");
        }
        Console.WriteLine("CPU Choice" + cpuChoice); 
        //compare the two choices and determine a winner
        if (playerChoice = "rock" && cpuChoice = "paper")
        {
            Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
            Console.WriteLine("The CPU wins. \n");
            cpuScore++;
        }
      
        }
        //putput the results
        // give winner a point 

      }

		 
