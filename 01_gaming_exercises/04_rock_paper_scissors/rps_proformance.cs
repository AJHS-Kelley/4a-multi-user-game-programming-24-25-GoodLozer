using System;

class rps {
     static void Main() {
        ///PlayerVariables
         
      int playerScore = 0; 
      string playerChoice = "";
      int numDraws = 0;

      //Cpu variables

      int cpuScore = 0;
      string cpuChoice = "";



      //testing game loop
      int loopCount = 0;
      int loopReqs = 0; // req = request reqs = requests
      Console.WriteLine("How many loops do you need?\n Type an INTERGER and press enter.\n"); 
      loopReqs = Convert.ToInt32(Console.ReadLine()); 
		 
		  Random rnd = new Random ();

      while (loopCount < loopReqs)
      {
        //Allow cpu to sellect randomly
       
        int cpuRand = rnd.Next(0,3);

        if (cpuRand == 0)
        {
            cpuChoice = "rock";
        }
        else if (cpuRand == 1)
        {
            cpuChoice = "paper";
        }
        else if (cpuRand == 2)
        {
            cpuChoice = "scissors";
        }
        else
        {
            Console.WriteLine("Unable to determine cpu choice\n");
        }

             //player random
          int playerRand = rnd.Next(0,3);                    
        
        
        if (playerRand == 0)
        {
            playerChoice = "rock";
        }
        else if (playerRand == 1)
        {
            playerChoice = "paper";
        }
        else if (playerRand == 2)
        {
            playerChoice = "scissors";
        }
        else
        {
            Console.WriteLine("Unable to determine player choice\n");
        }
        

            //Console.WriteLine("CPU Choice" + cpuChoice); 
        //compare the two choices and determine a winner
        if (playerChoice == "paper" && cpuChoice == "paper")
        {
            Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
            Console.WriteLine("Its a tie.\n");
            numDraws++;
			//numDraws = numDraws + 1;
        }
        else if (playerChoice == "rock" && cpuChoice == "rock")
        {
            Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
            Console.WriteLine("Its a tie.\n");
            numDraws++;
			//numDraws = numDraws + 1;
        }
        else if (playerChoice == "scissors" && cpuChoice == "scissors")
        {
            Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
            Console.WriteLine("Its a tie.\n");
            numDraws++;
			//numDraws = numDraws + 1;
        }
        else if (playerChoice == "paper" && cpuChoice == "rock")
        {
            Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
            Console.WriteLine("You won.\n");
            playerScore++;
			//playerScore = playerScore + 1;
        }
        else if (playerChoice == "scissors" && cpuChoice == "paper")
        {
           Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
           Console.WriteLine("You won.\n");
            playerScore++;
			//playerScore = playerScore + 1;
        }
        else if (playerChoice == "rock" && cpuChoice == "scissors")
        {
         Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
         Console.WriteLine("You won.\n");
            playerScore++;
			//playerScore = playerScore + 1;
        }
        else if (playerChoice == "scissors" && cpuChoice == "rock")
        {
          Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
          Console.WriteLine("Cpu won.\n");
            cpuScore++;
			//cpuScore = cpuScore +1;
        }
        else if (playerChoice == "paper" && cpuChoice == "scissors")
        {
           Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
           Console.WriteLine("Cpu won.\n");
            cpuScore++; 
			//cpuScore = playerScore + 1;
        }
        else if (playerChoice == "rock" && cpuChoice == "paper")
        {
           Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
           Console.WriteLine("Cpu won.\n");
            cpuScore++;
			//cpuScore = playerScore + 1;
        }
        loopCount++;
        
       
      
        
        //output the results
        // give winner a point 

	  }
		Console.WriteLine($"playerScore: {playerScore}\n"); 
        Console.WriteLine($"cpuScore: {cpuScore}\n"); 
        Console.WriteLine($"numDraws: {numDraws}\n"); 
	 }
}

	 

