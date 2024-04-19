using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishpot : MonoBehaviour, Interactable
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
        if (Backpack.fishpot < 4)
        {
            Backpack.fishpot += 1;
            Destroy(gameObject);
        }
        //EnduranceBar.fill += 0.5f;
    }
}
