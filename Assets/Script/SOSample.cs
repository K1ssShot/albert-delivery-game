using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Numbers", menuName = "ScriptableObjects/Numbers")]
public class SOSample : ScriptableObject
{
    public GameObject CarPrefabOne;

    public int NumberIntOne = 1;
    public int NumberIntTwo = 2;
    public int NumberIntThree = 3;
}
