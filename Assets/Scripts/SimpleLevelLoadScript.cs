using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleLevelLoadScript : MonoBehaviour {
    public void onClick()
    {
        SceneManager.LoadScene("Beginner1");
    }

}
