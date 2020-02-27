using System;
using Model;

public class Program
{
  public static void Main()
  {
    Game.Energy = 5;
    Console.WriteLine("\nCurrent Health: " + PrintEnergyBar() + " " + Game.Energy + "\n");
    QuestionOne();
    QuestionTwo();
    QuestionThree();
    QuestionFour();
    QuestionFive();
    QuestionSix();
  }
  public static void AddEnergy()
  {
    Game.Energy++;
  }
  public static void LoseEnergy()
  {
    Game.Energy--;
  }
  public static string PrintEnergyBar()
  {
    char[] energyBar = {'|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'};
    for(int i = 1; i < Game.Energy + 1; i++)
    {
      energyBar[i] = '#';
    }
    return String.Join("", energyBar);
  }
  public static void CheckIfDead()
  {
    if(Game.IsDead())
    {
      Console.WriteLine("You have died from your terrible choices. Rethink your life...");
      Console.WriteLine("Would you like to restart the game? [Y] or [N].");
      string restartAnswer = Console.ReadLine();
      if (restartAnswer == "N")
      {
        Console.WriteLine("Goodbye......");
        Environment.Exit(0);
      }
      else 
      {
        Main();
      }
      
    }
  }

  public static void Win()
  {
    if(Game.Won())
    {
      Console.WriteLine("You have perfect health, you Won!");
      Console.WriteLine("Would you like to restart the game? [Y] or [N].");
      string restartAnswer = Console.ReadLine();
      if (restartAnswer == "N")
      {
        Console.WriteLine("Goodbye......");
        Environment.Exit(0);
      }
      else 
      {
        Main();
      }
    }
  }

  // Question 1:
  public static void QuestionOne()
  {
    Console.WriteLine("Good Morning!  You have to be at work by 8:00a.  Would you like to: \ngo for a quick run [A] | get a McMuffin? [B]");
    string userChoiceOne = Console.ReadLine();
    if (userChoiceOne == "A")
    {
      AddEnergy();
    }
    else if (userChoiceOne == "B")
    {
      LoseEnergy();
    }
    else 
    {
      Console.WriteLine("Sorry. Please type [A] or [B].");
      QuestionOne();
    }
    Console.WriteLine("\nCurrent Health: " + PrintEnergyBar() + " " + Game.Energy + "\n");
  }

  // Question 2:
  public static void QuestionTwo()
  {
    Console.WriteLine("You still feel tired, do you want to:\nDrink Water [A] | Drink Soda [B]");
    string userChoiceOne = Console.ReadLine();
    if (userChoiceOne == "A")
    {
      AddEnergy();
    }
    else if (userChoiceOne == "B")
    {
      LoseEnergy();
    }
    else 
    {
      Console.WriteLine("Sorry. Please type [A] or [B].");
      QuestionTwo();
    }
    Console.WriteLine("\nCurrent Health: " + PrintEnergyBar() + " " + Game.Energy + "\n");
  }

  // Question 3:
  public static void QuestionThree()
  {
    Console.WriteLine("Would you like to:\nWalk to work [A] | Drive to work [B]");
    string userChoiceOne = Console.ReadLine();
    if (userChoiceOne == "A")
    {
      AddEnergy();
    }
    else if (userChoiceOne == "B")
    {
      LoseEnergy();
    }
    else 
    {
      Console.WriteLine("Sorry. Please type [A] or [B].");
      QuestionThree();
    }
    Console.WriteLine("\nCurrent Health: " + PrintEnergyBar() + " " + Game.Energy + "\n");
  }

    // Question 4:
  public static void QuestionFour()
  {
    Console.WriteLine("Would you like to:\nHave a salad for lunch [A] | Have fried chicken for lunch? [B]");
    string userChoiceOne = Console.ReadLine();
    if (userChoiceOne == "A")
    {
      AddEnergy();
    }
    else if (userChoiceOne == "B")
    {
      LoseEnergy();
    }
    else 
    {
      Console.WriteLine("Sorry. Please type [A] or [B].");
      QuestionFour();
    }
    Console.WriteLine("\nCurrent Health: " + PrintEnergyBar() + " " + Game.Energy + "\n");
  }

  // Question 5:
  public static void QuestionFive()
  {
    Console.WriteLine("Would you like to: \nHead back to work after lunch [A] | Go for a walk? [B]");
    string choice = Console.ReadLine();
    if (choice == "A")
    {
      LoseEnergy();
    }
    else if (choice == "B")
    {
      AddEnergy();
    }
    else {
      Console.WriteLine("Sorry. Please type [A] or [B].");
      QuestionFive();
    }
    Console.WriteLine("\nCurrent Health: " + PrintEnergyBar() + " " + Game.Energy + "\n");
    CheckIfDead();
    Win();
  }

  // Question ^:
  public static void QuestionSix()
  {
    Console.WriteLine("You are done with work for the day! Would you like to:\nGo to the gym [A] | Go to the bar [B]");
    string choice = Console.ReadLine();
    if (choice == "A")
    {
      AddEnergy();
    }
    else if (choice == "B")
    {
      LoseEnergy();
    }
    else {
      Console.WriteLine("Sorry. Please type [A] or [B].");
      QuestionSix();
    }
    Console.WriteLine("\nCurrent Health: " + PrintEnergyBar() + " " + Game.Energy + "\n");
    CheckIfDead();    
    Win();
  }
}