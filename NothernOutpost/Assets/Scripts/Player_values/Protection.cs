using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Protection : MonoBehaviour
{

    public static bool gas_mask; //хранит информацию о том, надет ли противогаз
    public Image value_PN;
    public static float fill; //уровень защиты

    void Start()
    {
        fill = 0.1f; //значение по умолчанию
        gas_mask = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && fill == 0.1f)
        {
            gas_mask = true;

        }
        if (Input.GetKeyDown(KeyCode.G) && fill == 0.25f)
        {
            gas_mask = false;

        }

        if (gas_mask) //если надет противогаз
        {
            fill = 0.25f;
        }
        if (!gas_mask)
        {
            fill = 0.1f;
        }


        value_PN.fillAmount = fill;

    }
}
