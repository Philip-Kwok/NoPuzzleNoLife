using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class UpArrow : MonoBehaviour
{
    float y = 100;
    //object to instantiate when player touches game object
    public GameObject finish;
    public Rigidbody2D rb;
    //when other which is this a var name
    public void OnTriggerStay2D(Collider2D collision)
    {
        rb.AddForce(new Vector2(0, y));
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        rb.velocity = Vector2.zero;
    }
}
