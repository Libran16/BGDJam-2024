using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerOnTouch : MonoBehaviour
{
    public GameObject CanvasKalah;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Player>() != null)
        {
            CanvasKalah.SetActive(true);
            Destroy(collision.gameObject);
        }
    }  
}
