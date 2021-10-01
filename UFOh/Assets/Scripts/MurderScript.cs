using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderScript : MonoBehaviour
{
    public int health = 60;
    public GameObject deathEffect;
    public GameObject camera;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            
            Die();
        }
    }

    void Die()
    {
        camera.GetComponent<screenShake>().TriggerShake();
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
