using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterDataBase : ScriptableObject
{
    public List<GameObject> CharacterPrefabsList;
    public Character[] _selectedCharacter;

    public int CharacterCountpred = 0;
    public int CharacterCount
    {
        get
        {
            return _selectedCharacter.Length;
        }
    }

    public Character GetCharacter(int index)
    {
        return _selectedCharacter[index];
    }
}
