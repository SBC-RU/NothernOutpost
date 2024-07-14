using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BP9 : MonoBehaviour, Interactable
{
    public Sprite icons; //слот для картинки

    public bool isOn; //переменная для проверки состояния
    public bool full_pack;
    //public static int bp9_maxsize;







    public string GetDescription() //вывод подсказки
    {
        if (isOn)
        {
            return "<color=yellow>Патроны пистолет [E]</color>";

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
        //bp9_maxsize = 45;
        int count = Random.Range(1, 16);
        if (((count + Backpack.bp9_ost) <= BasicConst.bp9_maxsize) && (!full_pack))
        {
            Backpack.bp9_ost += count;
            Destroy(gameObject);
            Debug.Log("+");
            Debug.Log($"{count}");
            Debug.Log($"{Backpack.bp9_ost}");
        }
        //else if (full_pack || ((count + Backpack.bp9_ost) > Const.bp9_maxsize))
        else
        {
            Backpack.bp9_ost = BasicConst.bp9_maxsize;
            Destroy(gameObject);
            Debug.Log("FULL");
            Debug.Log($"{count}");
            Debug.Log($"{Backpack.bp9_ost}");


        }

    }
}
