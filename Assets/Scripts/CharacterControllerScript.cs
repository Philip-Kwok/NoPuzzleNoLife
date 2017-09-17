using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharacterControllerScript : MonoBehaviour
{
    float speed = 4.0f;
    Vector3 pos;
    Transform tr;

    void Start()
    {
        pos = transform.position;
        tr = transform;
    }

    void FixedUpdate()
    {

        if (CrossPlatformInputManager.GetAxis("Horizontal") > 0.9 && tr.position == pos)
        {
            pos += Vector3.right;
        }
        else if (CrossPlatformInputManager.GetAxis("Horizontal") < -0.9 && tr.position == pos)
        {
            pos += Vector3.left;
        }
        else if (CrossPlatformInputManager.GetAxis("Vertical") > 0.9 && tr.position == pos)
        {
            pos += Vector3.up;
        }
        else if (CrossPlatformInputManager.GetAxis("Vertical") < -0.9 && tr.position == pos)
        {
            pos += Vector3.down;
        }
        else
        {
            pos = tr.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }

    void OnCollisionEnter2D()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        x = (int)x;
        y = (int)y;
        z = (int)z;
        Vector3 away = new Vector3(x, y, z);
        pos = away;
    }

}

