using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MainMenu : MonoBehaviour
{
    private InputAction leftMouseClick;
    void Awake()
    {
        leftMouseClick = new InputAction(binding: "<Mouse>/leftButton");
        leftMouseClick.performed += ctx => LeftMouseClicked();
        leftMouseClick.Enable();
    }

    // Update is called once per frame
  

    private void LeftMouseClicked()
    {
        leftMouseClick.Disable();
        SceneManager.LoadScene(1);
    }


    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Update the Text on the screen depending on current position of the touch each frame
            leftMouseClick.Disable();
            SceneManager.LoadScene(1);
        }
    }



}
