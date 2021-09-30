using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_murderScript : MonoBehaviour
{
    public int health = 3;
    public int damage = 1;
    public GameObject deathEffect;

    /*public void TakeDamage()
    {

        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    */
    public void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    } 
}
