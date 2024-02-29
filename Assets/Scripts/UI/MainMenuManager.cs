using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace UI { 
public class MainMenuManager : MonoBehaviour
{
    //for the main mainmenu game scene going to the next scene
    public GameObject HighScoreBoard;
    public ScoreCount ScoreCount;
    public TextMeshProUGUI CurrentPlayerScore;
    public TextMeshProUGUI PlayerHighScore;
    void Start()
    {
        ScoreCounter();
    }

    public void ScoreCounter()
    {
        CurrentPlayerScore.text = ScoreCount.CurrentScore.ToString();
        
        ScoreCount.AddPoints(0);
        PlayerHighScore.text = ScoreCount.HighScore.ToString();
        
    }

    public void PlayButton(string sceneName)
    {

        SceneManager.LoadScene(sceneName);

    }

    public void HighScoreButton()
    {
        HighScoreBoard.SetActive(true);
        
    }

    public void BackButton()
    {
        HighScoreBoard.SetActive(false);
    }
}
}