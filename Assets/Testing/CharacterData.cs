using UnityEngine;
using UnityEngine.Serialization;


// Define an enumeration to represent different character types
public enum PlayerID
{
    Yellow, // Yellow character
    Blue, // Blue character
    Violet, // Violet character
    Bike // Bike character
}

// Mark the class as serializable to allow its instances to be serialized
[System.Serializable]
public class CharacterData
{
    // The type of character
    public PlayerID PlayerID;

    // The name of the character
    public string CharacterName;

    // The prefab (template) used to instantiate the character in the game
    public GameObject CharacterPrefab;

    // Constructor for the CharacterList class
   
}