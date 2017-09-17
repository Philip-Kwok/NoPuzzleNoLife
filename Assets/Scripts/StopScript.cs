using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class StopScript : MonoBehaviour
{

    
    public GameObject finish;
    public Rigidbody2D rb;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        rb.velocity = Vector2.zero;
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        rb.velocity = Vector2.zero;
    }

}
