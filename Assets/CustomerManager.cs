using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    [SerializeField] private List<Transform> _customerPositionList;
    [SerializeField] private GameObject _customerPrefab;
    private int _currentSpawnIndex = 0;
    private bool _customerPackage = false;


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
        if (!_customerPackage &&_currentSpawnIndex < _customerPositionList.Count)
        {
            var customer = _customerPositionList[_currentSpawnIndex];
            Instantiate(_customerPrefab, customer.position, Quaternion.identity, customer);
            _customerPackage = true;

        }
    }
    public void OnCustomer()
    {
        _currentSpawnIndex++;
        CustomerSpawnPosition();
        _customerPackage = false;
        Debug.Log(" Package delivered");
        UIManager.PlayerScore += 2;
    }
}
