using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase2 : ScriptableObject
{
    public Character2[] character;

    public int characterCount{
        get{
            return character.Length;
        }
    }

    public Character2 getCharacter(int index){
        return character[index];
    }
}
