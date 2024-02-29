using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCharacter : MonoBehaviour
{
   
    [SerializeField] private CharacterDataBase _characterDataBase;

    private void Start()
    {
        SpawnCharacter();
    }

    private void SpawnCharacter()
    {
        // for the character to be spawned in level1 from the character selection
        Instantiate(_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
    }
}
