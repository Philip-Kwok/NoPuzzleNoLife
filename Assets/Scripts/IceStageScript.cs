using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class IceStageScript : MonoBehaviour
{
    float x = 0;
    float y = 0;
    Vector2 collide;
    public GameObject UI;
    public Rigidbody2D rb;
    float moveHorizontal;
    float moveVertical;
    Vector2 pos;
    void Start()
    {
        pos = transform.position;
    }

    void FixedUpdate()
    {
        moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        moveVertical = CrossPlatformInputManager.GetAxis("Vertical");
        if (moveHorizontal > 0.8)
        {
            //moveHorizontal = 1;
            UI.SetActive(false);
            x = 20;
            collide = Vector2.down;
               
        }
        else if (moveHorizontal < -0.8 )
        {
            //moveHorizontal = -1;
            UI.SetActive(false);
            x = -20;
            collide = Vector2.up;
        }
        else if (moveVertical > 0.8 )
        {
            //moveVertical = 1;
            UI.SetActive(false);
            y = 20;
            collide = Vector2.left;
        }
        else if (moveVertical < -0.8)
        {
            //moveVertical = -1;
            UI.SetActive(false);
            y = -20;
            collide = Vector2.right;
        }
        else
        {
            UI.SetActive(true);
        }
        rb.AddForce(new Vector2(x, y));
    }

    void OnCollisionEnter2D()
    {
        x = 0;
        y = 0;
        UI.SetActive(true);
        pos = collide;
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * 5);


        //moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        //moveVertical = CrossPlatformInputManager.GetAxis("Vertical");
    }

}

