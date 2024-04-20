using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gazmask : MonoBehaviour, Interactable
{
    public Sprite icons; //���� ��� ��������

    public bool isOn; //���������� ��� �������� ���������
    public string GetDescription() //����� ���������
    {
        if (isOn)
        {
            return "<color=yellow>������� [E]</color>";

        }
        return null;

    }
    public Sprite Geticon() //����� ��������
    {
        if (isOn)
        {
            return icons;

        }
        return null;

    }
    public void Interact() //������ �� ������������� (� ������ �������)
    {
        if (GunCircle.armor < 1)
        {
            GunCircle.armor = 1;
            Destroy(gameObject);
        }

    }
}
