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
        Destroy(gameObject);
    }
}
