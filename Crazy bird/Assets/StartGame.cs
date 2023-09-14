using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string Start;

    public void Load()
    {
        SceneManager.LoadScene(Start);
    }
        
}
