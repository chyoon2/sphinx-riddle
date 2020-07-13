using System;

namespace Egypt.Models {
public class Riddle
{
  private string _riddle;
  private string _answer;

  public Riddle(string riddle, string answer)
  {
    _riddle = riddle;
    _answer = answer;
  }
    public string GetRiddle()
  {
    return _riddle;
  }
  public string GetAnswer()
  {
    return _answer;
  }
}
}