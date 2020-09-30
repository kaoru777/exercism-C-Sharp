using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> highScore;
    public HighScores(List<int> list)
    {
        highScore = list;
    }

    public List<int> Scores()
    {
        return highScore;
    }

    public int Latest()
    {
        return highScore.Last();
    }

    public int PersonalBest()
    {
        return highScore.Max();
    }

    public List<int> PersonalTopThree()
    {
        return highScore.OrderByDescending(item => item).Take(3).ToList();
    }
}
