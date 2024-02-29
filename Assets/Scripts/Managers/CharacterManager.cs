using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public partial class CharacterManager : MonoBehaviour
{
    // for the character selection controller 
    [SerializeField] private CharacterDataBase _characterDataBase;
    private GameObject _spawnedCharacter;


   private void Start()
    {
        // to get the selected character from the character selection
        _spawnedCharacter = Instantiate (_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
    }
  

    public void next()
    {
        // for the next character controller from the character selection
        if (_characterDataBase.CharacterCount == _characterDataBase.CharacterPrefabsList.Count - 1)
        {
            _characterDataBase.CharacterCount = 0;
            Destroy(_spawnedCharacter);
            _spawnedCharacter = Instantiate(_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
        }
        else
        {
            _characterDataBase.CharacterCount += 1;
            Destroy(_spawnedCharacter);
            _spawnedCharacter = Instantiate(_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
        }

    }

    public void previous()
    {

        // for the previous character controller from the character selection
        if (_characterDataBase.CharacterCount == 0)
        {
            _characterDataBase.CharacterCount = _characterDataBase.CharacterPrefabsList.Count - 1;
            Destroy(_spawnedCharacter);
            _spawnedCharacter = Instantiate(_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
        }
        else
        {
            _characterDataBase.CharacterCount -= 1;
            Destroy(_spawnedCharacter);
            _spawnedCharacter = Instantiate(_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
        }
    }


    public void changeScene(int sceneID)
    {
       //load scene for the level 1 
        SceneManager.LoadScene(sceneID);
    }
}
