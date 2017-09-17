using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTouchLava : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D lava)
    {
        if (lava.gameObject.tag == "lava")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); ;
        }
        else if (lava.gameObject.tag == "other")
        {
            //null
        }
    }
}
