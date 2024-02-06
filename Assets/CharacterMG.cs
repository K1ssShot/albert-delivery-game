using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMG : MonoBehaviour
{
    [SerializeField] private CharacterDataBase Characterpredb;

    private void Start()
    {
        SpawnCharacter();
    }

    private void SpawnCharacter()
    {
        Instantiate(Characterpredb.CharacterPrefabsList[Characterpredb.CharacterCountpred]);
    }
}
