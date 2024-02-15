using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    // for the package collider using the new editior friendly spawnpoint
    
    private PackageManager _packageManager;
    public static Action OnPackageRetrievedEvent;


    private void Start()
    {
        _packageManager = FindObjectOfType<PackageManager>();
        if (_packageManager == null)
        {
            Debug.LogError("Package Manager not found in the scene!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.TryGetComponent(out Driver driver))
        {
            // Notify the package manager that the package has been collected
            _packageManager.OnPackageCollected();
            Destroy(gameObject);
            UIManager.PlayerScore += 1;
            //TODO: call customerspawn
            OnPackageRetrievedEvent?.Invoke();
        }
    }
}