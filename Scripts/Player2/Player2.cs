using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public CharacterDatabase2 characterDB;

    public SpriteRenderer artworkSprite;

    private int selectedOption2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("selectedOption2")){
            selectedOption2 = 0;
        }
        else{
            Load();
        }

        UpdateCharacter(selectedOption2);
    }

    private void UpdateCharacter(int selectedOption2){
        Character2 character = characterDB.getCharacter(selectedOption2);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load(){
        selectedOption2 = PlayerPrefs.GetInt("selectedOption2");
    }
}
