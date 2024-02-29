using System.Collections.Generic;
using UnityEngine;

// Import Unity's CreateAssetMenu attribute to define how this scriptable object can be created in the Unity Editor
[CreateAssetMenu(fileName = "CharacterData")]
public class CharacterCollection : ScriptableObject
{
    // A list of CharacterList objects, each representing a character
    public List<CharacterData> CharacterList;

    // The currently selected character
     public PlayerID CurrentPlayerID;

    // Other potential lists you might have commented out for reference
    //public List<GameObject> CharacterPrefabList;
    //public List<string> StringCharacters;
}
