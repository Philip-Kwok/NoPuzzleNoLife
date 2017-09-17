using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLava : MonoBehaviour {


    public GameObject invisTile;
    public GameObject LavaTile;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    invisTile.SetActive(true);
    //    LavaTile.SetActive(false);
    //}
    private void OnTriggerExit2D(Collider2D collision)
    {
        invisTile.SetActive(false);
        LavaTile.SetActive(true);
    }
}
