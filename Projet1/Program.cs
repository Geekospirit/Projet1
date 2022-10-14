int maxTurnNumbers = 5;
string? playerGuess = "";

while (playerGuess != "q")
{
    int age = new Random().Next(1, 120);
    bool win = false;
    Console.WriteLine("Devine mon âge entre 1 et 120 ans, appuie sur \"q\" pour quitter");

    for (int i = 1; i <= maxTurnNumbers && !win ; i++)
    {
        playerGuess = Console.ReadLine();
		if (playerGuess == "q")
		{
			Console.WriteLine("Au revoir !");
			break;
		}
		else
		{
			try
			{
				int playerGuessNumber = int.Parse(playerGuess);
				win = playerGuessNumber == age;
				if (playerGuessNumber > age)
				{
					Console.WriteLine("C'est moins !");
				}
				if (playerGuessNumber < age)
				{
					Console.WriteLine("C'est plus !");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ce n'est pas un âge valide, entrez un autre age : {ex}");
				i++;
			}
		}
    }
	if (playerGuess == "q")
	{
		break;
	}
	if (win)
	{
		Console.WriteLine($"Bravo!");
	} else
	{
		Console.WriteLine("Perdu, plus d'essais...");
	}
}