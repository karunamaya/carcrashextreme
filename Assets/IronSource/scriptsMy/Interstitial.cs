using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Interstitial : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        IronSource.Agent.loadInterstitial();
        IronSourceEvents.onInterstitialAdClosedEvent += InterstitialAdClosedEvent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Invoked when the interstitial ad closed and the user goes back to the application screen.
    void InterstitialAdClosedEvent()
    {
        IronSource.Agent.loadInterstitial();
    }

    public void interstitialplay() 
    {
     Debug.Log("реклама");
       IronSource.Agent.showInterstitial();
    }


    
}
