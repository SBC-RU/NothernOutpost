using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Backpack : MonoBehaviour
{
    public GameObject tea_cup;
    public static int tea;
    public TextMeshProUGUI ScoreTeaText;
    public GameObject milk_pot;
    public static int milkpot;
    public TextMeshProUGUI ScoreMilkText;
    public GameObject fish_pot;
    public static int fishpot;
    public TextMeshProUGUI ScoreFishText;
    public GameObject med_kit;
    public static int medkit;
    public TextMeshProUGUI ScoreMedkitText;
    // Start is called before the first frame update
    void Start()
    {
        tea = 0;
        milkpot = 0;
        fishpot = 0;
        medkit = 0;
    }

    // Update is called once per frame
    void Update()
    {
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
