using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       public void OpenOptionsMenu()
    {
        
       optionsMenu.SetActive(true);
        Time.timeScale = 0;
    
    }
    public void CloseOptionsMenu()
    {
         Time.timeScale = 1;
        optionsMenu.SetActive(false);
    
    }

     public void RestartLevel()
    {
        Time.timeScale = 1;Application.LoadLevel(Application.loadedLevel);}
     public void GoToMenu()
    {Time.timeScale = 1;
        Application.LoadLevel(0);}
}
