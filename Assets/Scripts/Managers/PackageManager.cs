using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageManager : MonoBehaviour
{
   // the new package manager and spawnpoint locator 
    [SerializeField] private List<Transform> _packagePositionList;
    [SerializeField] private GameObject _packagePrefab;
    private int _currentSpawnIndex = 0;

    private void Start()
    {
        SpawnPosition();

    }
    private void SpawnPosition()
    {
        // to get the spawn transform location of the game object
        if (_currentSpawnIndex < _packagePositionList.Count)
        {
            var package = _packagePositionList[_currentSpawnIndex];
            Instantiate(_packagePrefab, package.position, Quaternion.identity, package);
            
        }
    }

    public void OnPackageCollected()
    {
       //spawn condition index for the package spawner
        _currentSpawnIndex++;
        SpawnPosition();
        Debug.Log(" new package has been picked");

    }
}
