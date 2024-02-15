using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCustomer : MonoBehaviour
{
    
    private CustomerManager _customerManager;
    private PackageManager  _packageManager;
    public static Action OnCustomerRetriveEvent;

    private void Start()
    {
        _customerManager = FindAnyObjectByType<CustomerManager>();
        if (_customerManager == null)
        {
            Debug.LogError("Package Manager not found in the scene!");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: trygetcomponent driver
        _customerManager.OnCustomer();
        OnCustomerRetriveEvent?.Invoke();
        Destroy(gameObject);
        //TODO: spawnnextpackage
        _packageManager.SpawnNextPackage();



    }
}


