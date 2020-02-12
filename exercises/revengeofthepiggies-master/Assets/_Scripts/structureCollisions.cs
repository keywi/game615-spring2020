using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class structureCollisions : MonoBehaviour

{
    public ScoreManager scoreManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        scoreManager.StructureHittingAnotherStructure();
        
        Debug.Log("current score:" + scoreManager.getScore());
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
