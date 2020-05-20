using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public Transform Respawn;
    public AudioSource AS;
        
    void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.tag == "Player")
        {

            AS.Play(1);
            col.gameObject.transform.position = Respawn.position;
            
            
     
        }
    } 
}
