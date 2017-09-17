using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    public bool CanMute;
    //Use this for initialization
    void Start()
    {
        CanMute = true;
    }

    public void onClick()
    {
        if (CanMute)
        {
            AudioListener.pause = true;
            CanMute = false;
        }
        else
        {
            AudioListener.pause = false;
            CanMute = true;
        }
    }

}
