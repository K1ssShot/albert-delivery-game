
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerSpawner : MonoBehaviour
{
    // Reference to the character list data
   [FormerlySerializedAs("_characterData")] [SerializeField] private CharacterCollection _characterCollection;

    // Reference to the instantiated character object
    private GameObject _currentCharacterObject;

    // Start method invoked when the script is initialized
    private void Start()
    {
        // Get the current character from the character list data
        var currentCharacter = _characterCollection.CurrentPlayerID;
        // Call the method to select and instantiate the character
        CharacterSelected(currentCharacter);
    }

    // Method to select and instantiate the character
    private void CharacterSelected(PlayerID playerID)
    {
        // Find the data for the selected character
        var characterData = _characterCollection.CharacterList.Find(x => x.PlayerID == playerID);

        // Set the current character in the data list
        _characterCollection.CurrentPlayerID = playerID;

        // If the character data is found
        if (characterData != null)
        {
            // Instantiate the selected character's prefab at the current position
            _currentCharacterObject = Instantiate(characterData.CharacterPrefab, transform.position, Quaternion.identity);
        }
    }
}
