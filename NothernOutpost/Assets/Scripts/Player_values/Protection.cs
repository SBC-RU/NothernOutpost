using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Protection : MonoBehaviour
{

    public bool gas_mask; //������ ���������� � ���, ����� �� ����������
    public Image value_PN;
    public static float fill; //������� ������

    void Start()
    {
        fill = 0.1f; //�������� �� ���������
    }


    void Update()
    {
        if (gas_mask) //���� ����� ����������
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
