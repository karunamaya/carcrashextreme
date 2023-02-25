using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public bool isGarage;
    public int SceneToLoad;
    public void LoadScene()
    {
       
        SceneManager.LoadScene(SceneToLoad);
    }

   
}
