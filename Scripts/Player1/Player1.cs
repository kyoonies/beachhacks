using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public CharacterDatabase1 characterDB;

    public SpriteRenderer artworkSprite;

    private int selectedOption1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("selectedOption1")){
            selectedOption1 = 0;
        }
        else{
            Load();
        }

        UpdateCharacter(selectedOption1);
    }

    private void UpdateCharacter(int selectedOption1){
        Character1 character = characterDB.getCharacter(selectedOption1);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load(){
        selectedOption1 = PlayerPrefs.GetInt("selectedOption1");
    }
}
