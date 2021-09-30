using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableWallScript : MonoBehaviour
{
    public GameObject deathEffect;
    public void fuckingDie()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
