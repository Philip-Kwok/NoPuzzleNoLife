using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bp_6 : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3(7, 5, transform.position.z);
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }

    }
}
