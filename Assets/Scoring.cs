using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int numScore = 0;

    private void Update()
    {
     scoreText.text = numScore.ToString();
    }
}
