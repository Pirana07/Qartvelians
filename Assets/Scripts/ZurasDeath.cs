using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZurasDeath : MonoBehaviour
{
     SoundManagerr soundManagerr;
     private void Start(){
        soundManagerr = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundManagerr>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        soundManagerr.PlaySFX(soundManagerr.death);
    }
    }
