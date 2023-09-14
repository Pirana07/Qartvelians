using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPill : MonoBehaviour
{
     private float jumpingPower = 7f;
      [SerializeField] private Rigidbody2D rb;

   
        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pill"))
        {
       
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
    }
}

