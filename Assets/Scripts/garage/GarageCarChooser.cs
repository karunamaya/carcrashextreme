using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageCarChooser : MonoBehaviour
{
    public GameObject[] cars;
    public CarShopScript carShop;
    public int carsValue;
    public int currentCar;
    public int[] priceCars = new int[4];
    void Start()
    {
       
        priceCars[0] = 10000;
        priceCars[1] = 30000;
        carsValue = cars.Length;
       


        if (PlayerPrefs.HasKey("carNumber"))
        {

            currentCar = PlayerPrefs.GetInt("carNumber");

        }
        else
        {
            currentCar = 1;
            PlayerPrefs.SetInt("carNumber", currentCar);
            PlayerPrefs.Save();
        }
        foreach (GameObject car in cars)
        {

            car.SetActive(false);
            cars[currentCar - 1].SetActive(true);
        }
       carShop.ActiveCloseCarPanel(currentCar);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextCar()
    {
        if(currentCar < carsValue)
        {
            currentCar += 1;
            PlayerPrefs.SetInt("carNumber", currentCar);
            PlayerPrefs.Save();
            foreach (GameObject car in cars)
            {

                car.SetActive(false);
                cars[currentCar - 1].SetActive(true);
            }
            carShop.ActiveCloseCarPanel(currentCar);
        }
    }
    public void LastCar()
    {
        if (currentCar > 1)
        {
            currentCar -= 1;
            PlayerPrefs.SetInt("carNumber", currentCar);
            PlayerPrefs.Save();
            foreach (GameObject car in cars)
            {

                car.SetActive(false);
                cars[currentCar - 1].SetActive(true);
            }
            carShop.ActiveCloseCarPanel(currentCar);
        }

    }
    public void BuyCar()
    {



     if(PlayerPrefs.GetInt("money") >= priceCars[currentCar-2])
               {
                
     Debug.Log("buy="+ PlayerPrefs.GetInt("money"));
                 PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") - priceCars[currentCar-2]));
                PlayerPrefs.Save();

                      if(PlayerPrefs.GetInt("car"+currentCar+"Bought") == 0)
                      PlayerPrefs.SetInt("car"+currentCar+"Bought", 1);

               }

carShop.ActiveCloseCarPanel(currentCar);
    }
}
