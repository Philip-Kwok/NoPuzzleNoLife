using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpToSpot : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3(10, transform.localPosition.y, transform.position.z);
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }

    }
}
