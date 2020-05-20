using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("level");
    }
    
}
