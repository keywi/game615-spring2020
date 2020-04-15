using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public string Choice;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
   
    // Update is called once per frame
    void Update()
    {

    }
    public void LoadBlackPlayer()
    {
        Choice = "black";
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void LoadWhitePlayer()
    {
        Choice = "white";
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

   
}

