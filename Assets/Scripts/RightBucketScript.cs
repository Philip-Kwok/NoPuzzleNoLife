using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBucketScript : MonoBehaviour {

    public GameObject blackborder;

    public void OnTriggerEnter2D(Collider2D other)


    {
        if (other.gameObject.tag == "Player")
        {
       
            blackborder.transform.position = new Vector3(-10, -50, 0);
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }

    }
}
