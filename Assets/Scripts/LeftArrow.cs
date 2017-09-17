using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class LeftArrow : MonoBehaviour
{
    float x = -100;
    //object to instantiate when player touches game object
    public GameObject finish;
    public Rigidbody2D rb;
    //when other which is this a var name
    public void OnTriggerStay2D(Collider2D collision)
    {
        rb.AddForce(new Vector2(x, 0));
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        rb.velocity = Vector2.zero;
    }
}
