using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MurderScript : MonoBehaviour
{
    public int health = 60;
    public GameObject deathEffect;
    public GameObject camera;
    public bool isDead = true;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void loadNew()
    {
        SceneManager.LoadScene("LevelOne");
    }

    void Die()
    {
        camera.GetComponent<screenShake>().TriggerShake();
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Invoke("loadNew", 3.0f);
    }
}
