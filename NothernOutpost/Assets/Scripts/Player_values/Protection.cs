using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Protection : MonoBehaviour
{

    public bool gas_mask; //хранит информацию о том, надет ли противогаз
    public Image value_PN;
    public static float fill; //уровень защиты

    void Start()
    {
        fill = 0.1f; //значение по умолчанию
    }


    void Update()
    {
        if (gas_mask) //если надет противогаз
        {
            fill = 0.25f;
        }
        else
        {
            fill = 0.1f;
        }


        value_PN.fillAmount = fill;

    }
}
