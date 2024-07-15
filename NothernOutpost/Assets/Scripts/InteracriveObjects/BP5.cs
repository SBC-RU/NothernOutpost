using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BP5 : MonoBehaviour, Interactable
{
    public Sprite icons; //слот для картинки

    public bool isOn; //переменная для проверки состояния
    public bool full_pack;








    public string GetDescription() //вывод подсказки
    {
        if (isOn)
        {
            return "<color=yellow>Патроны 5x45 [E]</color>";

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
        int count = Random.Range(8, 31);
        if (((count + Backpack.bp5_ost) <= BasicConst.bp5_maxsize) && (!full_pack))
        {
            Backpack.bp5_ost += count;
            Destroy(gameObject);
            Debug.Log("+");
            Debug.Log($"{count}");
            Debug.Log($"{Backpack.bp5_ost}");
        }

        else
        {
            Backpack.bp5_ost = BasicConst.bp5_maxsize;
            Destroy(gameObject);
            Debug.Log("FULL");
            Debug.Log($"{count}");
            Debug.Log($"{Backpack.bp5_ost}");

        }

    }
}
