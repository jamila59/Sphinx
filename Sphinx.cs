
using System;
using System.Collections.Generic;

class Sphinx
{

public static Dictionary<int, string> questions = new Dictionary<int, string>() {
  {0, "No sooner spoken than broken?"},
  {1, "What does Mill + Walk + Key equals?"},
  {2, "What gets wetter and wetter the more it dries?"},
  {3, "I have a tail, and I have a head, but I have no body. I am NOT a snake. What am I?"} };

public static Dictionary<int, string> answers = new Dictionary<int, string>() { {0, "silence"}, {1, "Milwaukee"}, {2, "Towel"}, {3, "A coin"} };

public static int index = 0;

static void Main()
{
  Randomize();

  Console.WriteLine(questions[index]);
  string input = Console.ReadLine();

  if (input == answers[index])
  {
    Console.WriteLine("The sphinx have been defeated!");
  }
  else
  {
    Console.WriteLine("You have been defeated");
  }
}

static void Randomize()
{
  Random rand = new Random();
  index = rand.Next(0, 4);
}
}
