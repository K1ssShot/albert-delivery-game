using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timerC = 0f;
    [SerializeField] float startTime = 60f;
    [SerializeField] TextMeshProUGUI countdownText;
    public GameObject gameOverScreen;

    void Start()
    {
      timerC = startTime;
      Debug.Log("TimerCountdownStart");
    }

     void Update()
    {
     
     timerC -=1 * Time.deltaTime;
     countdownText.text = timerC.ToString("0");
     
        if (timerC <= 0)
        {
        Debug.Log("Gameover");
        timerC = 0;
        gameOverScreen.SetActive(true);
        
        }
       

    }
    public void tryAgain()
    {
    
    SceneManager.LoadScene(2);
    gameOverScreen.SetActive(false);
        

    }

    public void mainMenu()
    {
    SceneManager.LoadScene(0);
    gameOverScreen.SetActive(false);
    }


}
