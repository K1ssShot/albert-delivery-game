using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoudManager : MonoBehaviour
{
   
    public AudioSource _audioSource;


    public void Awake()
    {
       
    }

    public void OnEnable()
    {
        CustomerSpawner.OnPackageCollectedEvent += CustomerAudio;
    }

    public void OnDisable()
    {
        CustomerSpawner.OnPackageCollectedEvent -= CustomerAudio;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void CustomerAudio()
    {

        Debug.Log("this is the new sound effect");
        _audioSource.Play();

    }




}
