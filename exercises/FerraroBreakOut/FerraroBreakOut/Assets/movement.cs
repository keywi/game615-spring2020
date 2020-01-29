using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    void Start()
    {
        launchBall();
    }

    void launchBall()
    {
        transform.position = new Vector3(0, 0, 0);
        float forceX = Random.Range(-0.5f, 0.5f);

        float forceY = -2f;

        Vector3 force = new Vector3(forceX, forceY, 0);
        float magnitude = 500;

        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().AddForce(force * magnitude);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BottomWall")
        {
            launchBall();
        }
    }
}




//need to add failure state when it hits the "BottomWall"
//fix the movement issue
