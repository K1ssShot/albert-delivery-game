using System;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _customerPositionList;
    [SerializeField] private GameObject _customerPrefab;
    public static Action OnPackageCollectedEvent { get; set; }

    
    private void Awake()
    {
        _customerPositionList.Clear();
        foreach (Transform child in transform)
        {
            _customerPositionList.Add(child);
        }
    }

    public void OnEnable()
    {
        PackageSpawner.OnActionNewCustomerEvent += CustomerSpawnPosition;
    }

    public void OnDisable()
    {
        PackageSpawner.OnActionNewCustomerEvent -= CustomerSpawnPosition;
    }

    public void CustomerSpawnPosition()
    {   
        //random event 
        int randomIndex = UnityEngine.Random.Range(0, _customerPositionList.Count);
        Transform customerSpawner = _customerPositionList[randomIndex];
            var customerGameObject = Instantiate(_customerPrefab, customerSpawner.position, Quaternion.identity, customerSpawner);

        Debug.Log("Package picked and New Customer spawned");

        NewCustomer newCustomer = customerGameObject.GetComponent<NewCustomer>();
        newCustomer.Inject(this);

        
    }
    [Button]
    public void OnDelivered()
    {
        OnPackageCollectedEvent?.Invoke();
        //todo: needs action lister for scoring 
        Debug.Log("This is new event for the Customer Spawner");

    }
}
