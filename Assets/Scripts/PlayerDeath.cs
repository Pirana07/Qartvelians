using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDeath : MonoBehaviour
{
   private GameMaster gm;
    SoundManagerr soundManagerr;
    private bool Death = false;
 


    void Start()
    {
        gm = GameObject.FindObjectOfType<GameMaster>();
        transform.position = gm.lastCheckPointPosition;
       soundManagerr = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundManagerr>();
    }

  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Killer"))
        {
       
            soundManagerr.PlaySFX(soundManagerr.death);
                Death = true;
            
        }
    }
        
    void Update(){
        if(Death == true){
          
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

   


}