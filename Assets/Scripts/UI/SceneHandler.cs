using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 namespace UI { 
public class SceneHandler : MonoBehaviour
{
    //for the main mainmenu game scene going to the next scene
    public void PlayButton(string sceneName)
    {

        SceneManager.LoadScene(sceneName);

    }
}
}