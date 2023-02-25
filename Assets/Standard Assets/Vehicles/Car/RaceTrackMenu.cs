using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTrackMenu : MonoBehaviour
{
    public GameObject Track1Options;
    public GameObject Track2Options;
    public GameObject Track3Options;
    public GameObject RaceTrackSelectionPanel;
   

    public void Options1On()
    {
        RaceTrackSelectionPanel.SetActive(false);
        Track1Options.SetActive(true);

    }
    public void Options1Off()
    {
        RaceTrackSelectionPanel.SetActive(true);
        Track1Options.SetActive(false);
    }
    public void Options2On()
    {
        RaceTrackSelectionPanel.SetActive(false);
        Track2Options.SetActive(true);

    }
    public void Options2Off()
    {
        RaceTrackSelectionPanel.SetActive(true);
        Track2Options.SetActive(false);
    }
    public void Options3On()
    {
        RaceTrackSelectionPanel.SetActive(false);
        Track3Options.SetActive(true);

    }
    public void Options3Off()
    {
        RaceTrackSelectionPanel.SetActive(true);
        Track3Options.SetActive(false);
    }
}
