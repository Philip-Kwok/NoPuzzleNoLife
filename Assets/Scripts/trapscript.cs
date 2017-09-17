using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapscript : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "Player")
        {
  
            other.transform.position = new Vector3(-10, 6.25f, transform.position.z);
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }

    }
}
