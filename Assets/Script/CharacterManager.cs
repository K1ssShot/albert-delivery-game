using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class CharacterManager : MonoBehaviour
{
    
    public CharacterDataBase characterDB;
    public TextMeshProUGUI nameText;
    public SpriteRenderer artworksprite;

    private int selectedOption = 0;
    [SerializeField] private CharacterDataBase Characterpredb;
    private GameObject spawnedCharacter;


    void Start()
    {
        spawnedCharacter = Instantiate (Characterpredb.CharacterPrefabsList[Characterpredb.CharacterCountpred]);
    }
  

    public void next()
    {
        selectedOption++;
        if (selectedOption >=characterDB.CharacterCount)
        {
            selectedOption = 0;
        }
        UpdateCharacter(selectedOption);

    }

    public void prev()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount -1;
        }
        UpdateCharacter(selectedOption);
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworksprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }

  

    public void changeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }


}
