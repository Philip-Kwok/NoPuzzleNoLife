using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnColliderWarp : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D Finish)

    {
        if (Finish.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(1);
        }
        else if(Finish.gameObject.tag == "other")
            {

        }

    }
}