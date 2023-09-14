using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_subject : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }


     private void OnCollisionEnter2D (Collision2D other){
     if(other.gameObject.tag == "Player"){
        rb.velocity = new Vector2(66,-1);
     }
     }

}
