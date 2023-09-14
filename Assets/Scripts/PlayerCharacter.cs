using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCharacter : MonoBehaviour
{
    public Character_seclet characterDB;
  
    public SpriteRenderer artWorkSprite;

    private int selectedOption = 0;
   
   
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("selectedOption")){
        selectedOption = 0;
       }else{
        Load();
       }
        UpdateCharacter(selectedOption); 
    }

    private void UpdateCharacter(int selectedOption){
        Character character = characterDB.GetCharacter(selectedOption);
        artWorkSprite.sprite = character.CharacterSprite;
   
    }

    private void Load(){
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    
}
