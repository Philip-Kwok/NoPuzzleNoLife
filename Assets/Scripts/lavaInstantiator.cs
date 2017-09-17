using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaInstantiator : MonoBehaviour {

    public GameObject lava;

    public void OnTriggerEnter2D(Collider2D other)


    {
        if (other.gameObject.tag == "Player")
        {
            //GameObject obj = Instantiate(lava) as GameObject;
            lava.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }

    }

}
