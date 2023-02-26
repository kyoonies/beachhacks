using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase1 : ScriptableObject
{
    public Character1[] character;

    public int characterCount{
        get{
            return character.Length;
        }
    }

    public Character1 getCharacter(int index){
        return character[index];
    }
}
