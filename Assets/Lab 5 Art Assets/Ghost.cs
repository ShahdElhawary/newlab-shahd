using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : EnemyController
{
   
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.flipX = !sr.flipX;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Flip();
        }
        else if (other.tag == "Wall")
        {
            Flip();
        }
    }

    void Update()
    {
        
    }
}
