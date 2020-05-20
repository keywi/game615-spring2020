using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class coins : MonoBehaviour
{
    public TextMesh txt;

    void OnTriggerEnter2D(Collider2D col)
    {
        //Destory(GetComponent<RigidBody>());
        txt.text += "1";
    }
}
