using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractGameObject : MonoBehaviour {

    public GameObject finish;

    public void OnTriggerEnter2D(Collider2D other)

       
    {
        if (other.gameObject.tag == "Player" && Input.GetMouseButton(0))
        {
            
            finish.transform.position = new Vector3(-9.52f, 5.25f, 0);
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }

    }
}
