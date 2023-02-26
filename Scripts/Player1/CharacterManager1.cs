using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager1 : MonoBehaviour
{
    public CharacterDatabase1 characterDB;

    public SpriteRenderer artworkSprite;

    private int selectedOption1 = 0;

    void Start(){
        if(!PlayerPrefs.HasKey("selectedOption1")){
            selectedOption1 = 0;
        }
        else{
            Load();
        }

        UpdateCharacter(selectedOption1);
    }

    public void NextOption(){
        selectedOption1++;

        if(selectedOption1 >= characterDB.characterCount){
            selectedOption1 = 0;
        }

        UpdateCharacter(selectedOption1);
        Save();
    }

    public void BackOption(){
        selectedOption1--;

        if(selectedOption1 < 0){
            selectedOption1 = characterDB.characterCount - 1;
        }

        UpdateCharacter(selectedOption1);
        Save();
    }

    private void UpdateCharacter(int selectedOption1){
        Character1 character = characterDB.getCharacter(selectedOption1);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load(){
        selectedOption1 = PlayerPrefs.GetInt("selectedOption1");
    }

    private void Save(){
        PlayerPrefs.SetInt("selectedOption1", selectedOption1);
    }

}
