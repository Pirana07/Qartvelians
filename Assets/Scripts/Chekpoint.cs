using UnityEngine;

public class Chekpoint : MonoBehaviour
{ 
    private GameMaster  gm;

    SoundManagerr soundManagerr;

    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameMaster>();
        soundManagerr = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundManagerr>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("CheckPointTriggred!");
            gm.lastCheckPointPosition = transform.position;
            soundManagerr.PlaySFX(soundManagerr.chekpoint);

        }
    }
}