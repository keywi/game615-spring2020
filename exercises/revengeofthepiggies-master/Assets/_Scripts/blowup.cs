using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowup : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    
}


