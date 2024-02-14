using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // for the package collider using the new editior friendly spawnpoint
    private PackageManager _packageManager;

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
        if (other.TryGetComponent(out Driver driver))
        {
            // Notify the package manager that the package has been collected
            _packageManager.OnPackageCollected();
            // Optionally, you can destroy the package prefab once it's collected
            Destroy(gameObject);
        }
    }
}