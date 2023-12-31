using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class characterManager : MonoBehaviour
{

    public Character_seclet characterDB;
    public TMP_Text nameTXT;
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


    public void NextOption(){
        selectedOption++;

        if(selectedOption >= characterDB.CharacterCount){
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    public void BackOption(){
        selectedOption--;
        if(selectedOption < 0){
            selectedOption = characterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
        Save();

    }

    private void UpdateCharacter(int selectedOption){
        Character character = characterDB.GetCharacter(selectedOption);
        artWorkSprite.sprite = character.CharacterSprite;
        nameTXT.text = character.CharacterName;
    }

    private void Load(){
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void Save(){
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void PlayGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }

  
}
