using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RightArrow : MonoBehaviour {
    float x = 50;
    //object to instantiate when player touches game object
    public GameObject stuff;
   
    //when other which is this a var name

    public void OnTriggerStay2D(Collider2D collision)
    {
        
        stuff.GetComponent<Rigidbody2D>().AddForce(new Vector2(x, 0));
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        stuff.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
