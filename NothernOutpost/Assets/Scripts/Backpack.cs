using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Backpack : MonoBehaviour
{

    public static int tea;
    public static int milkpot;
    public static int fishpot;
    public static int medkit;

    //Боеприпасы (остаток)
    public static int bp12_ost;
    public static int bp5_ost;
    public static int bp9_ost;

    public TextMeshProUGUI Scorebp9_ostText;
    public TextMeshProUGUI Scorebp5_ostText;
    public TextMeshProUGUI Scorebp12_ostText;
    public TextMeshProUGUI ScoreTeaText;
    public TextMeshProUGUI ScoreMilkText;
    public TextMeshProUGUI ScoreFishText;
    public TextMeshProUGUI ScoreMedkitText;
    public GameObject bp9ost;
    public GameObject bp5ost;
    public GameObject bp12ost;
    public GameObject tea_cup;
    public GameObject milk_pot;
    public GameObject fish_pot;
    public GameObject med_kit;
    // Start is called before the first frame update
    void Start()
    {
        //Е Д А  и  А П Т Е Ч К И
        tea = 0;
        milkpot = 0;
        fishpot = 0;
        medkit = 0;

        //Б О Е П Р И П А С Ы
        bp12_ost = 0;
        bp5_ost = 0;
        bp9_ost = 0;
}

    // Update is called once per frame
    void Update()
    {
        //вывод остатка патронов в инвентарь
        if (bp12_ost > 0)
        {
            bp12ost.SetActive(true);
            Scorebp12_ostText.text = bp12_ost.ToString();
        }
        if (bp12_ost == 0)
        {
            bp12ost.SetActive(false);
        }

        if (bp5_ost > 0)
        {
            bp5ost.SetActive(true);
            Scorebp5_ostText.text = bp5_ost.ToString();
        }
        if (bp5_ost == 0)
        {
            bp5ost.SetActive(false);
        }

        if (bp9_ost > 0)
        {
            bp9ost.SetActive(true);
            Scorebp9_ostText.text = bp9_ost.ToString();
        }
        if (bp9_ost == 0)
        {
            bp9ost.SetActive(false);
        }

        if (tea > 0)
        {
            tea_cup.SetActive(true);
            ScoreTeaText.text = "x" + tea.ToString();
        }
        if (tea == 0)
        {
            tea_cup.SetActive(false);
        }


        if (milkpot > 0)
        {
            milk_pot.SetActive(true);
            ScoreMilkText.text = "x" + milkpot.ToString();
        }
        if (milkpot == 0)
        {
            milk_pot.SetActive(false);
        }


        if (fishpot > 0)
        {
            fish_pot.SetActive(true);
            ScoreFishText.text = "x" + fishpot.ToString();
        }
        if (fishpot == 0)
        {
             fish_pot.SetActive(false);
        }


        if (medkit > 0)
        {
            med_kit.SetActive(true);
            ScoreMedkitText.text = "x" + medkit.ToString();
        }
        if (medkit == 0)
        {
            med_kit.SetActive(false);
        }
    }
}
