using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftclick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void onClick(Collider2D other)
    {
        Input.GetMouseButton(0);

        if (other.gameObject.tag == "action")
        {
            Debug.Log("click!");
        }
        else if (other.gameObject.tag == "other")
        {
            //null
        }
    }
}
