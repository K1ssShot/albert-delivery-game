using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "CurrentScore")]
public class ScoreCount : ScriptableObject
{
    public int CurrentScore = 0;
    public int HighScore = 0;

    public void AddPoints(int pointsToAdd)
    {
        CurrentScore += pointsToAdd;
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
            
        }

    

        
    }

}
