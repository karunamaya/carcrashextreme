using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    public GameObject finish;
    public int finishMoney;
    public int currentLevel;
    bool finishTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


 private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == 8 && !finishTag)
        {

            finishTag = true;
            finish.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "REWARDED "+ finishMoney+ "$";
            finish.SetActive(true);

    GameObject.Find("Mediation").GetComponent<Interstitial>().interstitialplay();
            
            if(PlayerPrefs.GetInt("lastOpenLevel") == currentLevel)
            {
                PlayerPrefs.SetInt("lastOpenLevel", PlayerPrefs.GetInt("lastOpenLevel") + 1);
                PlayerPrefs.Save();

            }
            if (PlayerPrefs.HasKey("money"))
            {
                int money = PlayerPrefs.GetInt("money") + finishMoney;
                PlayerPrefs.SetInt("money", money);
                PlayerPrefs.Save();

            }
            else
            {
                PlayerPrefs.SetInt("money", finishMoney);
                PlayerPrefs.Save();
            }

        }

    }
}
