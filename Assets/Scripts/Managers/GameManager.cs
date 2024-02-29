using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   //for timer UI system Condition 
   
    private float _timerCountdown = 0f;
    [SerializeField]private float _startTime = 60f;
    [SerializeField]private TextMeshProUGUI _countdownText;
    public GameObject GameOverScreen;
    
    
    
    private void Start()
    {
        _timerCountdown = _startTime;
        Debug.Log("TimerCountdownStart");
    }


    private void Update()
    {
        // to display the time from the UI 
        _timerCountdown -= 1 * Time.deltaTime;
        _countdownText.text = _timerCountdown.ToString("0");

        if (_timerCountdown <= 0)
        {
            Debug.Log("Gameover");
            _timerCountdown = 0;
            GameOverScreen.SetActive(true);
        }

    }
    
    
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
