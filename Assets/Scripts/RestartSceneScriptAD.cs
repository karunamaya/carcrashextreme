using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartSceneScriptAD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartCurrentScene()
    {

if(!PlayerPrefs.HasKey("restartCountAD"))
{
PlayerPrefs.SetInt("restartCountAD",1);
PlayerPrefs.Save();
SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
}
else {
if(PlayerPrefs.GetInt("restartCountAD") ==3)
{PlayerPrefs.SetInt("restartCountAD",1);
PlayerPrefs.Save();
    GameObject.Find("Mediation").GetComponent<Interstitial>().interstitialplay();
SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
    return;
}

if(PlayerPrefs.GetInt("restartCountAD") <3)
{
PlayerPrefs.SetInt("restartCountAD",PlayerPrefs.GetInt("restartCountAD")+1);
    SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
}


}
        
    }
}
