using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
      
    }

    public void NextLevel(int sceneNumber)
    {

        SceneManager.LoadScene(sceneNumber);

    }
    public void GoToMenu()
    {
        Application.LoadLevel(0);

    }

}
