using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarShopScript : MonoBehaviour
{
    public GarageCarChooser garage;
    public GameObject carClosePanel;
    public GameObject carChooseButton;
    void Start()
    {
//DelKeys();
//PlayerPrefs.SetInt("money",1000);
       if(!PlayerPrefs.HasKey("car1Bought"))
        { PlayerPrefs.SetInt("car1Bought", 1); }
         if(!PlayerPrefs.HasKey("car2Bought"))
        {PlayerPrefs.SetInt("car2Bought", 0);}
         if(!PlayerPrefs.HasKey("car3Bought"))
        {PlayerPrefs.SetInt("car3Bought", 0);}
         if(!PlayerPrefs.HasKey("car4Bought"))
        {PlayerPrefs.SetInt("car4Bought", 0);}
         if(!PlayerPrefs.HasKey("car5Bought"))
        {PlayerPrefs.SetInt("car5Bought", 0);}
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
    }

    
    void DelKeys()
    {
PlayerPrefs.DeleteKey("car1Bought");
PlayerPrefs.DeleteKey("car2Bought");
PlayerPrefs.DeleteKey("car3Bought");
PlayerPrefs.DeleteKey("car4Bought");
PlayerPrefs.DeleteKey("car5Bought");

    }

    public void ActiveCloseCarPanel(int currentCar)
    {
        if(PlayerPrefs.GetInt("car"+currentCar+"Bought") == 0)
        {
            carClosePanel.SetActive(true);
            carChooseButton.SetActive(false);
        }
        
        else  {carClosePanel.SetActive(false);
        carChooseButton.SetActive(true);
        }
        if(currentCar>1)
SetPriceOnButton(garage.priceCars[currentCar-2]);

    }

    void SetPriceOnButton(int price)
    {
carClosePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "BUY "+price;

    }

}
