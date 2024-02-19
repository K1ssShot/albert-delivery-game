using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCustomer : MonoBehaviour
{
    // for the sprite color controller
    [SerializeField] private Color32 _noPackageColor = new Color32(255, 255, 255, 255);
    private CustomerSpawner _customerManager;
    public static Action OnCustomerRetriveEvent;

    private void Start()
    {
        _customerManager = FindAnyObjectByType<CustomerSpawner>();
        if (_customerManager == null)
        {
            Debug.LogError("Package Manager not found in the scene!");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.TryGetComponent(out Driver driver))
        {
            //color will change and new package will spawn;
            driver._spriteRenderer.color = _noPackageColor;
            Debug.Log("Color Back to normal");
            UIManager.PlayerScore += 2;
            OnCustomerRetriveEvent?.Invoke();
            Destroy(gameObject);
            


        }

    }
}


