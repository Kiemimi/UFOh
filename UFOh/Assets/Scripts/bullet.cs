using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<MurderScript>() == true)
        {
            MurderScript murderscript = hitInfo.GetComponent<MurderScript>();
            if (murderscript != null)
            {
                murderscript.TakeDamage(20);
            }
        }
        else if (hitInfo.GetComponent<breakableWallScript>() == true)
        {
            breakableWallScript breakableWall = hitInfo.GetComponent<breakableWallScript>();
            if(breakableWall != null)
            {
                breakableWall.fuckingDie();
            }
        }
        Destroy(gameObject);
    }
}
