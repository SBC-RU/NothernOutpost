using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class InventoryMenu : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject Canvas;
    public GameObject InventoryMenuUI;
    public GameObject MapMenuUI;
    public GameObject LibraryMenuUI;
    public GameObject InventoryPanel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("T");
            if (GameIsPaused)
            {

                Button_back();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }
    public void Button_back()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        InventoryPanel.SetActive(false);
        InventoryMenuUI.SetActive(false);
        MapMenuUI.SetActive(false);
        LibraryMenuUI.SetActive(false);

        Canvas.SetActive(true);
    }
    public void Pause()
    {
        Canvas.SetActive(false);

        InventoryPanel.SetActive(true);
        MapMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;


    }

}
