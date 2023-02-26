using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager2 : MonoBehaviour
{
    public CharacterDatabase2 characterDB;

    public SpriteRenderer artworkSprite;

    private int selectedOption2 = 0;

    void Start(){
        if(!PlayerPrefs.HasKey("selectedOption2")){
            selectedOption2 = 0;
        }
        else{
            Load();
        }

        UpdateCharacter(selectedOption2);
    }

    public void NextOption(){
        selectedOption2++;

        if(selectedOption2 >= characterDB.characterCount){
            selectedOption2 = 0;
        }

        UpdateCharacter(selectedOption2);
        Save();
    }

    public void BackOption(){
        selectedOption2--;

        if(selectedOption2 < 0){
            selectedOption2 = characterDB.characterCount - 1;
        }

        UpdateCharacter(selectedOption2);
        Save();
    }

    private void UpdateCharacter(int selectedOption2){
        Character2 character = characterDB.getCharacter(selectedOption2);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load(){
        selectedOption2 = PlayerPrefs.GetInt("selectedOption2");
    }

    private void Save(){
        PlayerPrefs.SetInt("selectedOption2", selectedOption2);
    }
}
