using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemovement : MonoBehaviour
{
    public KeyCode leftKey;
    public KeyCode RightKey;

    public float paddleSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftKey) && transform.position.x > -8f)
        {
            transform.position = new Vector3(transform.position.x - paddleSpeed, transform.position.y, 0);
        }
        if (Input.GetKey(RightKey) && transform.position.x < 8f)
        {
            transform.position = new Vector3(transform.position.x + paddleSpeed, transform.position.y, 0);
        }
    }
}
