using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMG : MonoBehaviour
{
    [SerializeField] private CharacterDataBase _characterDataBase;

    private void Start()
    {
        SpawnCharacter();
    }

    private void SpawnCharacter()
    {
        Instantiate(_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
    }
}
