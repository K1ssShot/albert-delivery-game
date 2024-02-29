using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCustomer : MonoBehaviour
{
    // for the sprite color controller
    [SerializeField] private Color32 _noPackageColor = new Color32(255, 255, 255, 255);
     private CustomerSpawner _customerManager;
    

    private void Start()
    {
        //_customerManager = FindAnyObjectByType<CustomerSpawner>();
        //if (_customerManager == null)
      //  {
      //      Debug.LogError("Package Manager not found in the scene!");
      //  }

    }



    public void Inject (CustomerSpawner customerSpawner)
    {
       _customerManager = customerSpawner;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.TryGetComponent(out Driver driver))
        {
            //color will change and new package will spawn;
            _customerManager.OnDelivered();
            driver._spriteRenderer.color = _noPackageColor;
            Debug.Log("Color Back to normal");
            //UIManager.PlayerScore += 2;
            Destroy(gameObject);
 
        }

    }
}


