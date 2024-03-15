using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnduranceBar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI message;
    public static float accuracy; //����������� �������� (��� ��������)
    public static float impactforce; //����������� ���� ����� (������� ���)
    public Image value_EU;
    public static float fill; //������� ���

    void Start()
    {
        fill = 1f; //�������� ������������ �� ��������� 100%
    }
    public void textMessage() //����� ��������������
    {
        //message.text = "���������� ���������";
    }

    void Update()
    {
        if (fill > 0f) //���� ������������ > 0, �� ��� ����� ���� ���������
        {
            //fill -= Time.deltaTime * 0.1f; //���� ����������
        }

        if (fill >= 0.8f) 
        {
            if (fill > 1f) //���� ������������ > 100%, ��� ������������� 100%
            {
                fill = 1f;
            }
            if (HealthBar.fill < 1f) //���� ������������ > 100%, ��� ������������� 100%
            {
                fill -= Time.deltaTime * 0.02f; //������������ ���������� -2%
                HealthBar.fill += Time.deltaTime * 0.01f; //�������� ����������������� +1%
            }
            accuracy = 1f; //���� �������� 1
            impactforce = 1f; //���� ���� ����� 1
            PlayerMovement.speed = 14f; //�������� 14
        }
        if (fill >= 0.3f && fill<0.8f)
        {
            accuracy = 0.87f; //���� �������� 0.87
            impactforce = 0.6f; //���� ���� ����� 0.6
            PlayerMovement.speed = 12f; //�������� 12
        }
        if (fill < 0.3f)
        {
            accuracy = 0.65f; //���� �������� 0.65
            impactforce = 0.4f; //���� ���� ����� 0.4
            PlayerMovement.speed = 10f; //�������� 10
            //textMessage();
        }

        value_EU.fillAmount = fill;

    }
}
