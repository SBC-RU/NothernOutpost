using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gazmask : MonoBehaviour, Interactable
{
    public Sprite icons; //слот для картинки

    public bool isOn; //переменная для проверки состояния
    public string GetDescription() //вывод подсказки
    {
        if (isOn)
        {
            return "<color=yellow>Поднять [E]</color>";

        }
        return null;

    }
    public Sprite Geticon() //вывод картинки
    {
        if (isOn)
        {
            return icons;

        }
        return null;

    }
    public void Interact() //профит от использования (и судьба объекта)
    {
        if (GunCircle.armor < 1)
        {
            GunCircle.armor = 1;
            Destroy(gameObject);
        }

    }
}
