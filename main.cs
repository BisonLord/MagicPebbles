using System;

class TextAdventure
{
	static void Main()
	{
		string notice = "Please use lower case for your answers. Travel Options are surrounded by parenthesis. When asked a question you can answer \"yes\" or \"no\" \n \n";
		string gameIntro = "Welcome. You are an apprentice to your great Uncle Boris, a bumbling old druid who lives in the depths of a verdant forest.\n\n";
		string askForName = "What is your name?: ";
		string playerName;
		string travelOptions = "\n\tYour Great Uncle Boris's (hut). \n\n\tDeeper into the (forest). \n\tTo the clear blue mountain (lake). \n\tTo the charred (peaks)! \n\n\tThe (shrine) of the evil Un-Rotan! \n\nOption: ";
		string answer;
		string askWhereToTravel = "Where would you like to travel? ";
		string whereIsThat = "Where is that?";
		
		
		string forest = "forest";
		string forestGnome = "gnome";
		string gnomeSound = "squeaks";
		string gnomeAction = "smiles";
		string gnomePocket = "pocket";
		string forestDescription = "You go deeper into the forest.\nA gnome greets you from the undergrowth, \"Hi, {0}!\"\nIt holds a shiny pebble in short grubby fingers. \"Here, take this magical pebble!\"\n Do you take the pebble?";
		
		string lake = "lake";
		string lakeRider = "lake rider";
		string riderSound = "grunts";
		string riderAction = "nods";
		string riderPocket = "seaweed satchel";
		string lakeDescription = "A man made of shells, riding a horse made of waves, emerges from the lake. He holds a staff of coral and lowers it towards you. An amulet dangles from the end. \"Hello {0}, hold out your hand, I have a magical pebble for you!\"\n Do you take the pebble?";
		
    string peaks = "peaks";
    string peaksGoblin = "goblin";
    string goblinSound = "snarls";
    string goblinAction = "gesticulates wildly";
    string goblinPocket = "dirty leather apron";
    string peaksDescription = "You climb the peaks and enjoy the view. As you scrabble onto a higher ledge you come upon a dishevled looking goblin cooking a haunch of meat over a campfire. His eyes widen in surprise and he prepares throws a pebble at your head!\n Do you try and catch the pebble?";
    
    string magicJewel = @"
   ___________________
   \-_   RAKADAB   _-/
    \  -- _   _ --  / 
     \      -      /  
      \ AB  |  RA /   
       \    |    /    
        \   |   /     
         \  |  /      
          \ | /       
           \|/        
            V";
		string unRotanShrineDescription = "You stand at the entrance to shrine to Un-Rotan. A wide set of steps, made of dark brown stone fade away into the maw of the Cairn. Your Uncle Boris had always warned you to stay clear of this place. The manifestation of evil awaits you...";
		string unRotanResponse;
		
		string shrineWarning = "Your Uncle told you not to go there...it is a place of great evil.";
		string canPassToShrine = "However, with your pockets full of magical pebbles you are able to pass through the forbidden gateway to the shrine of Un-Rotan";
		string cannotPassWithoutPebbles = "You cannot pass without the magical pebbles!";
		string unRotanAttacks = "The fiend Un-Rotan descends upon you! Made of smoke and ash, with eyes like burning coals and a mouth like an inferno!\nYou have but a moment to utter a single word before your are consumed!";
		
		string abrakadabraSuccess = "The magic pebbles appear before your eyes, in a flash of blue light they fuse together into a shining diamond inscribed with the word \"ABRAKADABRA\". The blinding light of the magical jewel banishes the fiend back to the depths of the abyss.";
		string defeatedUnRotan = "\n\nCongratulations - You defeated Un-Rotan!\n\n";
		
		string consumedByUnRotan = "The fiend swirls around you, suffocates you with its unbearable heat and drags your soul into the abyss!";
		string defeatedByUnRotan = "\n\nOh No! - You failed to defeat Un-Rotan!\n\n";
		
    
		int forestPebbles = 0;
		string forestMagicWord = "AB";
		int peakPebbles = 0;
		string peakMagicWord = "RA";
		int lakePebbles = 0;
		string lakeMagicWord = "RAKADAB";
		int totalPebbles = 0; 
		
				
		string hutDescription = "You stand outside your great Uncle's hut. \nIt is empty, your uncle must be in the forest collecting holly for his potions.";
		string dropPebble = "To drop a pebble type (forest), (peaks) or (lake) or type (done) if you are finished.";
		string droppedPebble = "Pebble Dropped!";
		string invalidPebbleType = "Invalid pebble type or not enough pebbles!";
		string pebbleAnswer;
		
		
		string pebbleCount = "You have {0} forest pebbles, {1} lake Pebbles and {2} peak pebbles for a total of {3} pebbles.";
		string tookThePebble;
		string pocketThePebble = "You take the pebble and notice a strange inscription that says \"{0}\". You'll have to ask your uncle what it means, but for now you put it in your pocket.";
		string fullPockets = "The {0} notices your bulging pockets, \"I see Your pockets are full!\" it {1}, \"I will hold onto this one then.\"";
		string didNotWantPebble = "The {0} looks at you and {1} before putting the pebble into it's {2}. \"Goodbye!\", it says, disappearing into the {3}.";

		string exitedGame = "Exiting...";
		

		Console.WriteLine(notice);
		Console.WriteLine(gameIntro);
		Console.Write(askForName);
		playerName = Console.ReadLine();
		
		Console.WriteLine();
		
		Console.WriteLine(hutDescription);
		Console.WriteLine(askWhereToTravel);
		Console.Write(travelOptions);
		answer = Console.ReadLine();
	  Console.WriteLine();
		
		
		//1st required Loop
		while (answer != "exit")
		{
			switch (answer)
			{
				case ("forest"):
				  Console.WriteLine();
					Console.Write(forestDescription, playerName);
					tookThePebble = Console.ReadLine();
					if (totalPebbles >= 3)
					{
					  Console.WriteLine(fullPockets, forestGnome, gnomeSound);
					}
					else if (tookThePebble == "yes")
					{
					  totalPebbles++;
					  forestPebbles++;
					  Console.WriteLine(pocketThePebble, forestMagicWord);
					} 
					else 
					{
					  Console.WriteLine(didNotWantPebble, forestGnome, gnomeAction, gnomePocket, forest);  
					}
					Console.WriteLine();
					Console.Write(askWhereToTravel);
					answer = Console.ReadLine();
					break;
					
				case ("lake"):
				  Console.WriteLine();
          Console.Write(lakeDescription, playerName);
					tookThePebble = Console.ReadLine();
					if (totalPebbles >= 3)
					{
					  Console.WriteLine(fullPockets, lakeRider, riderSound);
					}
					else if (tookThePebble == "yes")
					{
					  totalPebbles++;
					  lakePebbles++;
					  Console.WriteLine(pocketThePebble, lakeMagicWord);
					} 
					else 
					{
					  Console.WriteLine(didNotWantPebble, lakeRider, riderAction, riderPocket, lake);  
					}
					Console.WriteLine();
					Console.Write(askWhereToTravel);
					answer = Console.ReadLine();
					break;
					
				case ("peaks"):
				  Console.WriteLine();
          Console.Write(peaksDescription);
					tookThePebble = Console.ReadLine();
					if (totalPebbles >= 3)
					{
					  Console.WriteLine(fullPockets, peaksGoblin, goblinSound);
					}
					else if (tookThePebble == "yes")
					{
					  totalPebbles++;
					  peakPebbles++;
					  Console.WriteLine(pocketThePebble, peakMagicWord);
					} 
					else 
					{
					  Console.WriteLine(didNotWantPebble, peaksGoblin, goblinAction, goblinPocket, peaks);  
					}
					Console.WriteLine();
					Console.Write(askWhereToTravel);
					answer = Console.ReadLine();
					break;
					
				case ("hut"):
				  Console.WriteLine();
					Console.WriteLine(hutDescription);
					Console.WriteLine(pebbleCount, forestPebbles, lakePebbles, peakPebbles, totalPebbles);
					
					Console.WriteLine(dropPebble);
					pebbleAnswer = Console.ReadLine();
					
					//2nd required Loop
					while (pebbleAnswer != "done")
					{
					  if (pebbleAnswer == "forest" && forestPebbles > 0)
					  {
					    forestPebbles--;
					    totalPebbles--;
					    Console.WriteLine(droppedPebble);
					    Console.WriteLine(dropPebble);
					    pebbleAnswer = Console.ReadLine();
					  }
					  else if (pebbleAnswer == "lake" && lakePebbles > 0)
					  {
					    lakePebbles--;
					    totalPebbles--;
					    Console.WriteLine(droppedPebble);
					    Console.WriteLine(dropPebble);
					    pebbleAnswer = Console.ReadLine();
					  }
					  else if (pebbleAnswer == "peaks" && peakPebbles > 0)
					  {
					    peakPebbles--;
					    totalPebbles--;
					    Console.WriteLine(droppedPebble);
					    Console.WriteLine(dropPebble);
					    pebbleAnswer = Console.ReadLine();
					  }
					  else
					  {
					   Console.WriteLine(invalidPebbleType); 
					   Console.WriteLine(dropPebble);
					   pebbleAnswer = Console.ReadLine();
					  }
					}
					
					Console.Write(askWhereToTravel);
					answer = Console.ReadLine();
					break;
					
				case ("shrine"):
				  Console.WriteLine();
				  Console.WriteLine(shrineWarning);
				  if (forestPebbles >= 1 && lakePebbles >=1 && peakPebbles >= 1 || totalPebbles >= 3)
				  {
				    Console.WriteLine(canPassToShrine);
				    Console.WriteLine(unRotanShrineDescription);
				    Console.WriteLine(unRotanAttacks);
				    unRotanResponse = Console.ReadLine();
				    if (unRotanResponse == "abrakadabra")
				    {
				      Console.WriteLine(magicJewel);
				      Console.WriteLine(abrakadabraSuccess);
				      Console.WriteLine(defeatedUnRotan);
				    }
				    else
				    {
				      Console.WriteLine(consumedByUnRotan);
				      Console.WriteLine(defeatedByUnRotan);
				    }
				    answer = "exit";
				  }
				  else
				  {
				    Console.WriteLine(cannotPassWithoutPebbles);
				    Console.Write(askWhereToTravel);
				    answer = Console.ReadLine();
				  }
					break;
					
				case ("exit"):
				  break; 
				
				default:
				  Console.WriteLine();
					Console.WriteLine(whereIsThat);
					Console.Write(askWhereToTravel);
					answer = Console.ReadLine();
					break;
			}
		}
		Console.WriteLine(exitedGame);
	}	
}