using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMoneySetter : MonoBehaviour
{
    public Text moneyText;
    void Start()
    {
        if (PlayerPrefs.HasKey("money"))
        {
            moneyText.text = "" + PlayerPrefs.GetInt("money");
            

        }
        else
        {
            moneyText.text = "0";
        }


    }

    // Update is called once per frame
    void Update()
    {
         if (PlayerPrefs.HasKey("money"))
        {
            moneyText.text = "" + PlayerPrefs.GetInt("money");
            

        }
    }
}
