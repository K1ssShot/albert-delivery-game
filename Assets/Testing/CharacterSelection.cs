using System;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class CharacterSelection : MonoBehaviour
{
    // Reference to the scriptable object holding character data
    public CharacterCollection _characterCollection;

    // Default character selection
     public PlayerID PlayerIDSelection = PlayerID.Yellow;

    // Reference to the instantiated character object
     private GameObject _currentCharacterObject;

    // Start method invoked when the script is initialized
    [Button] // Unity Inspector button attribute
    private void Start()
    {
        // Start by selecting the default character
        SelectedCharacter(PlayerIDSelection);
    }

    // Method to handle character selection
    private void SelectedCharacter(PlayerID playerID)
    {
        // Find the data for the selected character
        var characterData = _characterCollection.CharacterList.Find(x => x.PlayerID == playerID);
        Debug.Log($"character is selected {playerID}-{characterData.PlayerID}");

        // Set the current character in the data list
        _characterCollection.CurrentPlayerID = playerID;

        // If the character data is found
        if (characterData != null)
        {
            // If there's already a character object instantiated, destroy it
            if (_currentCharacterObject != null)
            {
                Destroy(_currentCharacterObject);
            }
            
            // Instantiate the selected character's prefab at the current position
            _currentCharacterObject = Instantiate(characterData.CharacterPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            // Log an error if character data is not found
            Debug.Log("Character data not found for: " + playerID);
        }
    }
    
    // Method to handle next button click
    public void NextButton()
    {
        int totalCharacters = Enum.GetValues(typeof(PlayerID)).Length;
        // Move to the next character in the enum sequence
        PlayerIDSelection = (PlayerID)(((int)PlayerIDSelection + 1) % totalCharacters);
        // Select the next character
        SelectedCharacter(PlayerIDSelection);
    }
    
    // Method to handle previous button click
    public void PreviousButton()
    {
        int totalcharacters = Enum.GetValues(typeof(PlayerID)).Length;
        int previousIndex = ((int)PlayerIDSelection - 1 + totalcharacters) % totalcharacters;
        // Move to the previous character in the enum sequence
        //PlayerIDSelection = (PlayerID)(((int)PlayerIDSelection - 1 + (int)PlayerID.Bike) % totalcharacters);
        // Select the previous character
        PlayerIDSelection = (PlayerID)previousIndex;
        SelectedCharacter(PlayerIDSelection);
    }

    // Method to load a new scene
    public void Starting(string sceneID)
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneID);
    }
}