using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
   public void PlayGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void quit(){
    Application.Quit();
   }

   public void Character(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }

}
