using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milkpot : MonoBehaviour, Interactable
{
    public Sprite icons; //���� ��� ��������

    public bool isOn; //���������� ��� �������� ���������


    public string GetDescription() //����� ���������
    {
        if (isOn)
        {
            return "<color=yellow>������������ [E]</color>";

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
        if (Backpack.milkpot < 4)
        {
            Backpack.milkpot += 1;
            Destroy(gameObject);
        }
        //HealthBar.fill += 0.25f;
    }
}
