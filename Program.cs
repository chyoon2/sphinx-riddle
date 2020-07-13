using System;
using System.Collections.Generic;
using Egypt.Models;

namespace Egypt {
  public class Program
  {
    public static void Main()
    {

      Riddle rid1 = new Riddle ("I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "A fire");
      Riddle rid2 = new Riddle ("What's my name?","DMX");
      Riddle rid3 = new Riddle ("What runs around the whole yard without moving?","A fence");
      
      Riddle[] problemSet = { rid1, rid2, rid3 };
      
      for (int i=0; i < problemSet.Length; i++)
      {
        Console.WriteLine(problemSet[i].GetRiddle());
        string answer = Console.ReadLine();

        if (answer == problemSet[i].GetAnswer())
        {
          Console.WriteLine("Ya dun good kid");
        }
        else {
          Console.WriteLine("Ya dun kid");
          break;
        }
      }
    }
  }
}