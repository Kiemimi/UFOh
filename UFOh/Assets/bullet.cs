using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bullet : MonoBehaviour
{
    public GameObject deathEffect;
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Destroy(gameObject);
        hitInfo.GetComponent<scr_murderScript> ().health -=1;
        Debug.Log(hitInfo + " HP = " + hitInfo.GetComponent<scr_murderScript>().health + ":");
        if (hitInfo.GetComponent<scr_murderScript>().health <= 0)
        {

            Destroy(hitInfo);
            Destroy(hitInfo.gameObject, 0.5f);
            //Instantiate(deathEffect, transform.position, Quaternion.identity); 
        }
    }
}
