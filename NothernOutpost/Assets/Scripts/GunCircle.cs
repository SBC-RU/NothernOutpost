using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunCircle : MonoBehaviour
{
    public GameObject circleImage;
    public GameObject gas_maskImage;
    public GameObject firstAndKitImage;
    public GameObject slot1Image;
    public GameObject slot2Image;
    public GameObject slot3Image;

    public static int armor;

    public bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        armor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q");
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
        if (armor == 0)
        {
            gas_maskImage.SetActive(false);
        }
        if (armor == 1)
        {
            gas_maskImage.SetActive(true);
        }

    }
    public void Button_back()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        circleImage.SetActive(false);
    }
    public void Pause()
    {
        circleImage.SetActive(true);
        Time.timeScale = 0.25f;
        GameIsPaused = true;


    }
}
