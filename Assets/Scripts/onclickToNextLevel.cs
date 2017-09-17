using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onclickToNextLevel : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene(5);
    }
}
