using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = .1f; //how fast player moves

    private bool FacingRight; //creating the function true or false statement to change the direction the character is facing

    // Start is called before the first frame update
    void Start()
    {
        FacingRight = true;

    }

    // Update is called once per frame
    void FixedUpdate()
        //attempt to make a 2d player controller
    {
        if (Input.GetKey(KeyCode.UpArrow)) //press up key to do:
        {
            transform.position += Vector3.up * speed; //move up 
        }
        if (Input.GetKey(KeyCode.DownArrow)) //press down key to do:
        {
            transform.position += Vector3.down * speed; //move down 
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //press left key to do:
        {
            transform.position += Vector3.left * speed; //move left
        }
        if (Input.GetKey(KeyCode.RightArrow)) //press right key 
        {
            transform.position += Vector3.right * speed; //move right 
        }


    }

    void flip() //flips the character if moving left moves left if moving right moves right
    {
        Vector3 direction = transform.localScale;
        direction.x *= -1;
        transform.localScale = direction;

    }

    void Update()
    {
        if (Input.GetAxisRaw ("Horizontal") > 0) //input on the x axis keeping track of which direction my player is going in, 
        {
            if (!FacingRight)
            {
                FacingRight = true; 
                flip();
            }
        } 
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            if (!FacingRight)
            {
                FacingRight = false;
               flip();
            }
        }
    }
    
}
