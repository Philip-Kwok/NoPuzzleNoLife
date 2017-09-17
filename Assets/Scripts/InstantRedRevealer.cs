using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantRedRevealer : MonoBehaviour {

    public GameObject map;
    
    void Start()
    {
        Invoke("reveal", 0);
        Invoke("hide", 2);
    }
    void reveal () {
        if (map.CompareTag("redTile"))
        {
           map.SetActive(false);
        }
        else { }
	}
    void hide()
    {
        if (map.CompareTag("redTile"))
        {
            map.SetActive(true);
        }
        else { }
    }
}
