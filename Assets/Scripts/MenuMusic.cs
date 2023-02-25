using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { GameObject[] am;
          am = GameObject.FindGameObjectsWithTag("menuMusic");
          Debug.Log(am.Length);
          if(am.Length ==2)
          Destroy(this.gameObject);

            if(am.Length ==1)
          DontDestroyOnLoad(am[0]);
         Destroy(GameObject.FindGameObjectWithTag("levelMusic"));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
