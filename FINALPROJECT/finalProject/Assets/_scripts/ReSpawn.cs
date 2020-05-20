using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public Transform Respawn; //when player hits an object respwan at the start of a level 
    public AudioSource AS; //creating the audio source to play a sound upon death 
        
    void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.tag == "Player")
        {

            AS.Play(1);
            col.gameObject.transform.position = Respawn.position;
            
            
     
        }
    } 
}
