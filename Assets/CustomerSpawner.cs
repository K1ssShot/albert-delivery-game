using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _customerPositionList;
    [SerializeField] private GameObject _customerPrefab;
  

    private void OnEnable()
    {
        Package.OnPackageRetrievedEvent += CustomerSpawnPosition;
    }

    private void OnDisable()
    {
        Package.OnPackageRetrievedEvent -= CustomerSpawnPosition;
    }

    public void CustomerSpawnPosition()
    {   
        //random event 
        int randomIndex = Random.Range(0, _customerPositionList.Count);
        Transform CustomerSpawner = _customerPositionList[randomIndex];
            var packageGameObject = Instantiate(_customerPrefab, CustomerSpawner.position, Quaternion.identity, CustomerSpawner);
            Debug.Log("Package picked and New Customer spawned");
       


        
    }
    public void OnCustomer()
    {
       
        CustomerSpawnPosition();
        Debug.Log(" Package delivered");
        
        

    }
}
