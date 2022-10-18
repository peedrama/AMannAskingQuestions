﻿// Amardeep Mann
// 10-17-2022
// Mini Challenge #3 - "Asking Questions"
// Ask the user for their name, ask them what time they woke up, and ouput a sentence to the console which includes both inputs

Console.Clear();

bool playAgain = true;

do {
  Console.WriteLine("\nHey bud. What's your name?");

  string userName = Console.ReadLine();

  Console.WriteLine("\nOh yeah. What time did you wake up today?");

  string wakeTime = Console.ReadLine();

  Console.WriteLine("\n" + userName + " woke up at " + wakeTime + " today! Wild\n");

  string response = "";
  do {
    Console.WriteLine("Do you want to play again? (Please enter \"yes\" or \"no\")");
    response = Console.ReadLine().ToLower();
  } while (response != "yes" && response != "no");

  if (response == "no") {
    playAgain = false;
    Console.WriteLine("\nGoodbye then!");
  }

} while (playAgain);