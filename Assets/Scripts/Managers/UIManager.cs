using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   
    public TextMeshProUGUI ScoreText;
    public static int PlayerScore = 0;
    public GameObject GameOverScreen;

    private void Update()
    {

        ScoreText.text = PlayerScore.ToString();
       // _countdownText.text = _timerCountdown.ToString("0");


    }
   // for the Main Menu UI and Game over UI 
    public void TryAgain(string levelName)
    {

        SceneManager.LoadScene(levelName);
        GameOverScreen.SetActive(false);


    }

    public void MainMenu(string levelName)
    {
        SceneManager.LoadScene(levelName);
        GameOverScreen.SetActive(false);
    }



}
