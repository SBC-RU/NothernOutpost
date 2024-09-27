using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GunCircle : MonoBehaviour
{
    public GameObject circleImage;
    public GameObject gas_maskImage;
    public GameObject firstAndKitImage;
    public GameObject slot1Image;
    public GameObject slot2Image;
    public GameObject slot3Image;
    
    //количество патронов
    public TextMeshProUGUI Scorebp9_ostText;
    public TextMeshProUGUI Scorebp5_ostText;
    public TextMeshProUGUI Scorebp12_ostText;

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
        Time.timeScale = 0.6f;
        GameIsPaused = true;


        //вывод количества патронов
        Scorebp12_ostText.text = Backpack.bp12_ost.ToString();
        Scorebp5_ostText.text = Backpack.bp5_ost.ToString();
        Scorebp9_ostText.text = Backpack.bp9_ost.ToString();

    }
}
