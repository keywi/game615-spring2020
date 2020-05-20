using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

   //remove start function 

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.position.x, player.position.y + .5f, this.transform.position.z); //the camera follows the player modified from angry birds assignment

    }
}
