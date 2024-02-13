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
        Characterpredb.CharacterCountpred = 0;
        spawnedCharacter = Instantiate (Characterpredb.CharacterPrefabsList[Characterpredb.CharacterCountpred]);
        UpdateCharacter(selectedOption);
    }
  

    public void next()
    {
        selectedOption++;
        if (selectedOption >=characterDB.CharacterCount)
        {
            selectedOption = 0;
        }
        UpdateCharacter(selectedOption);

        if (Characterpredb.CharacterCountpred == Characterpredb.CharacterPrefabsList.Count - 1)
        {
            Characterpredb.CharacterCountpred = 0;
            Destroy(spawnedCharacter);
            spawnedCharacter = Instantiate(Characterpredb.CharacterPrefabsList[Characterpredb.CharacterCountpred]);
        }
        else
        {
            Characterpredb.CharacterCountpred += 1;
            Destroy(spawnedCharacter);
            spawnedCharacter = Instantiate(Characterpredb.CharacterPrefabsList[Characterpredb.CharacterCountpred]);
        }

    }

    public void prev()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount -1;
        }
        UpdateCharacter(selectedOption);

       
        if (Characterpredb.CharacterCountpred == 0)
        {
            Characterpredb.CharacterCountpred = Characterpredb.CharacterPrefabsList.Count - 1;
            Destroy(spawnedCharacter);
            spawnedCharacter = Instantiate(Characterpredb.CharacterPrefabsList[Characterpredb.CharacterCountpred]);
        }
        else
        {
            Characterpredb.CharacterCountpred -= 1;
            Destroy(spawnedCharacter);
            spawnedCharacter = Instantiate(Characterpredb.CharacterPrefabsList[Characterpredb.CharacterCountpred]);
        }
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
