using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageManager : MonoBehaviour
{
    [SerializeField] private List<Transform> _packagePositionList;
    [SerializeField] private GameObject _packagePrefab;

    private void Start()
    {
        SpawnPosition();
    }
    private void SpawnPosition()
    {
        foreach(var position in _packagePositionList )
        {
            Instantiate(_packagePrefab, position.transform);
        }
    }
}
