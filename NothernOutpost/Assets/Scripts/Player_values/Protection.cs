using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Protection : MonoBehaviour
{

    public static bool gas_mask; //������ ���������� � ���, ����� �� ����������
    public Image value_PN;
    public static float fill; //������� ������

    void Start()
    {
        fill = 0.1f; //�������� �� ���������
        gas_mask = false;
    }


    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.Alpha4)) && fill == 0.1f && GunCircle.armor >= 1)
        {
            gas_mask = true;

        }
        if ((Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.Alpha4)) && fill == 0.25f)
        {
            gas_mask = false;

        }

        if (gas_mask) //���� ����� ����������
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
