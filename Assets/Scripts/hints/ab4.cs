using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ab4 : MonoBehaviour
{
    public Text mytext = null;
    public int counter = 0;
    public void changeText()
    {
        counter++;
        if (counter % 2 == 1)
        {
            mytext.text = "Looks like something is in the way!";
        }
        else
        {
            mytext.text = " ";
        }
    }

}
