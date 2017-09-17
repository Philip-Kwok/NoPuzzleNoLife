using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BR_Tele : MonoBehaviour {

    public GameObject finish;

    public void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "Player")
        {

            finish.transform.position = new Vector3(9, 1, transform.position.z);
            other.transform.position = new Vector3(7, 1, transform.position.z);
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }

    }
}
