using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PackageSpawner : MonoBehaviour
    {
        // the new package manager and spawnpoint locator 
        [SerializeField] private List<Transform> _packagePositionList; 
        [SerializeField] private GameObject _packagePrefab;
        public static Action OnActionNewCustomerEvent { get; set; }
        // [SerializeField] private CustomerSpawner _customerSpawner;

        private void Awake()
        {
            _packagePositionList.Clear();
            foreach (Transform child in transform)
            {
                _packagePositionList.Add(child);
            }
        }

        public void OnEnable()
        {
            CustomerSpawner.OnPackageCollectedEvent += SpawnNextPackage;
        }

        public void OnDisable()
        {
            CustomerSpawner.OnPackageCollectedEvent -= SpawnNextPackage;
        }


        private void Start()
        {
            SpawnNextPackage();

        }

        private void SpawnNextPackage()
        {
            // to get the spawn transform location of the game object

            Debug.Log("Delivered and spawn next Package");
            int randomIndex = UnityEngine.Random.Range(0, _packagePositionList.Count);
            Transform packageSpawner = _packagePositionList[randomIndex];
            var packageGameObject = Instantiate(_packagePrefab, packageSpawner.position, Quaternion.identity, packageSpawner);

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
            OnActionNewCustomerEvent?.Invoke();

        }
    }
