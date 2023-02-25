using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpenLevelsOnMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.childCount);
        if (PlayerPrefs.HasKey("lastOpenLevel"))
        {
            


        }
        else
        {
            PlayerPrefs.SetInt("lastOpenLevel",1);
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            if (PlayerPrefs.GetInt("lastOpenLevel") >= i + 1)
            {
                transform.GetChild(i).GetComponent<Image>().color = new Color32(255, 255, 255, 255); transform.GetChild(i).GetComponent<Button>().enabled = true;
            }
            else {transform.GetChild(i).GetComponent<Image>().color = new Color32(84, 84, 84, 255); transform.GetChild(i).GetComponent<Button>().enabled = false;
        }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
