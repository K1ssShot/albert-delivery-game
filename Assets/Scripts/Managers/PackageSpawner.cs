using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageSpawner : MonoBehaviour
{
   // the new package manager and spawnpoint locator 
    [SerializeField] private List<Transform> _packagePositionList;
    [SerializeField] private GameObject _packagePrefab;



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
        
            Debug.Log("Delivered and spawn next Package");
        int randomIndex = Random.Range(0, _packagePositionList.Count);
        Transform PackageSpawner = _packagePositionList[randomIndex];
        var packageGameObject =   Instantiate(_packagePrefab, PackageSpawner.position, Quaternion.identity, PackageSpawner);

        Package package = packageGameObject.GetComponent<Package>();
        package.Inject(this);

    }

    public void OnPackageCollected()
    {
        //spawn condition index for the package spawner

        // SpawnNextPackage();
        //Debug.Log(" new package has been picked");

        // todo: TRIGGER static event
            //TODO: call customerspawn
            Debug.Log("this is my new event in PackageSpawner");

    }


}