using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _customerPositionList;
    [SerializeField] private GameObject _customerPrefab;
    public static Action OnPackageCollectedEvent { get; set; }


    public void OnEnable()
    {
        PackageSpawner.OnactionNewCustomerEvent += CustomerSpawnPosition;
    }

    public void OnDisable()
    {
        PackageSpawner.OnactionNewCustomerEvent -= CustomerSpawnPosition;
    }

    private void Start()
    {
       // CustomerSpawnPosition();

    }

    public void CustomerSpawnPosition()
    {   
        //random event 
        int randomIndex = UnityEngine.Random.Range(0, _customerPositionList.Count);
        Transform CustomerSpawner = _customerPositionList[randomIndex];
            var customerGameObject = Instantiate(_customerPrefab, CustomerSpawner.position, Quaternion.identity, CustomerSpawner);

        Debug.Log("Package picked and New Customer spawned");

        NewCustomer newCustomer = customerGameObject.GetComponent<NewCustomer>();
        newCustomer.Inject(this);

        
    }
    public void OnDilevered()
    {
        OnPackageCollectedEvent?.Invoke();
        //todo: needs action lister for scoring 
        Debug.Log("This is new event for the Customer Spawner");

    }
}
