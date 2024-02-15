using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageManager : MonoBehaviour
{
   // the new package manager and spawnpoint locator 
    [SerializeField] private List<Transform> _packagePositionList;
    [SerializeField] private GameObject _packagePrefab;
    private int _currentSpawnIndex = 0;
    private bool _isDeliveringPackage = false;

    private void OnEnable()
    {
        NewCustomer.OnCustomerRetriveEvent += SpawnNextPackage;
    }

    private void OnDisable()
    {
        NewCustomer.OnCustomerRetriveEvent -= SpawnNextPackage;
    }


    private void Start()
    {
        SpawnNextPackage();

    }

    public void SpawnNextPackage()
    {
        // to get the spawn transform location of the game object
        if ((!_isDeliveringPackage && _currentSpawnIndex < _packagePositionList.Count))
        {
            var package = _packagePositionList[_currentSpawnIndex];
            Instantiate(_packagePrefab, package.position, Quaternion.identity, package);
            _isDeliveringPackage = true;

        }

    }

    public void OnPackageCollected()
    {
       //spawn condition index for the package spawner
        _currentSpawnIndex++;
        SpawnNextPackage();
        Debug.Log(" new package has been picked");
    }

}
