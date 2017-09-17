using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTileScript : MonoBehaviour {

    public GameObject switchTile;
    public GameObject switchTile1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switchTile.SetActive(true);
        switchTile1.SetActive(false);
    }

}
