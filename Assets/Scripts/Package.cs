using Unity.Collections;
using UnityEngine;
    public class Package : MonoBehaviour
    {
        // for the package collider using the new editior friendly spawnpoint
       
        [ReadOnly]
        public PackageSpawner _packageManager;
        //todo: remove action
        // public static Action OnPackageRetrievedEvent;


        private void Start()
        {
            //_packageManager = FindObjectOfType<PackageManager>();
            //if (_packageManager == null)
            //{
            //    Debug.LogError("Package Manager not found in the scene!");
            //}
        }

        public void Inject(PackageSpawner packageManager)
        {
            _packageManager = packageManager;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Driver driver))
            {
                  _packageManager.OnPackageCollected();
                // Notify the package manager that the package has been collected
                Destroy(gameObject);
                //TODO: call customerspawn

            }
        }
    }