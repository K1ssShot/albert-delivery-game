using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //for scoring system
    public TextMeshProUGUI scoreText;
    public static int numScore = 0;

   //for timer system
   
    float timerC = 0f;
    [SerializeField] float startTime = 60f;
    [SerializeField] TextMeshProUGUI countdownText;
    public GameObject gameOverScreen;
    void Start()
    {
        timerC = startTime;
        Debug.Log("TimerCountdownStart");
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

    void Update()
    {

        timerC -= 1 * Time.deltaTime;
        countdownText.text = timerC.ToString("0");

        if (timerC <= 0)
        {
            Debug.Log("Gameover");
            timerC = 0;
            gameOverScreen.SetActive(true);

        }
        scoreText.text = numScore.ToString();


    }


}
