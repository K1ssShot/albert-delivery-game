using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   
    public TextMeshProUGUI ScoreText;
    public static int PlayerScore = 0;

    private void Update()
    {
        //updates the Player score automatically from UI
        ScoreText.text = PlayerScore.ToString();
     

    }
   



}
