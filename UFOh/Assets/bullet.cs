using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.GetComponent<MurderScript>() == true)
        {
            Debug.Log("Yes");
        }
        Destroy(gameObject);
    }
}
