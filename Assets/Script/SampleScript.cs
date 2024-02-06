using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    [SerializeField] private SOSample _numbersSO;

    private void Start()
    {
        //spawn carprefabone
        Instantiate(_numbersSO.CarPrefabOne);
    }
}
