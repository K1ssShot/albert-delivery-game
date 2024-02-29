using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public ScoreCount ScoreCount;
    public TextMeshProUGUI PlayerScoreText;
    public TextMeshProUGUI FinalScoreText;
    //public int PlayerScore = 0;
    

    public void OnEnable()
    {
        CustomerSpawner.OnPackageCollectedEvent += ScorePoints;
    }

    public void OnDisable()
    {
        CustomerSpawner.OnPackageCollectedEvent -= ScorePoints;
    }
    private void ScorePoints()
    {
        //for the scoreCounter in player 
        ScoreCount.CurrentScore ++;
        Debug.Log(" package Delivered ScoreUpdated");
         PlayerScoreText.text = ScoreCount.CurrentScore.ToString();
         FinalScoreText.text = ScoreCount.CurrentScore.ToString();

         
    }

    public void TryAgain(string sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void MainMenu(string sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    

}
