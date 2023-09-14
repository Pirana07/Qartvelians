using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerr : MonoBehaviour
{
   [SerializeField] AudioSource musiSource;
   [SerializeField] AudioSource SFXSource;

   public AudioClip background;
   public AudioClip death;
   public AudioClip chekpoint;
   public AudioClip jump;
   public AudioClip dagtrole;
   public AudioClip nelazvio;
   public AudioClip aaaaa;
   public AudioClip Bukia;

   private void Start(){
    musiSource.clip = background;
    musiSource.Play();
   }

   public void PlaySFX(AudioClip clip){
      SFXSource.PlayOneShot(clip);
   }

   

}
