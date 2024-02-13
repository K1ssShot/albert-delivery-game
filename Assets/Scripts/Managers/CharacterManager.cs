using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class CharacterManager : MonoBehaviour
{
    [SerializeField] private CharacterDataBase _characterDataBase;
    private GameObject _spawnedCharacter;


   private void Start()
    {
        
        _spawnedCharacter = Instantiate (_characterDataBase.CharacterPrefabsList[_characterDataBase.CharacterCount]);
    }
  

    public void next()
    {

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

    public void prev()
    {

       
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
        SceneManager.LoadScene(sceneID);
    }
}
