using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI PlayerScoreText;
    public TextMeshProUGUI FinalScoreText;
    public int PlayerScore = 0;
    

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
        PlayerScore ++;
        Debug.Log(" package Delivered ScoreUpdated");
         PlayerScoreText.text = PlayerScore.ToString();
        FinalScoreText.text = PlayerScore.ToString();


    }

}
