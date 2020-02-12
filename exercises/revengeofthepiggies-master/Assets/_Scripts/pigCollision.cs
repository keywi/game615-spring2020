using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    const int TIME_TO_RESET = 10;
    Vector3 orginialPosition;
    Transform parent;

    private void Start()
    {
        orginialPosition = transform.localPosition;
        parent = transform.parent;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("ResetPiggy", TIME_TO_RESET);

        if (collision.gameObject.tag != "Floor")
        {
            scoreManager.PiggyHittingStructure();
            //Debug.Log("current score:" + scoreManager.getScore());
        }
    }
    void ResetPiggy()
    {

        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        transform.parent = parent;
        transform.localPosition = orginialPosition;
        Camera.main.GetComponent<CameraFollow>().resetCameraPosition(); 

    }
}
