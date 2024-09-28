using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UseManager регулирует использование/применение ресурсов, способы их активации и профит от применения
public class UseManager : MonoBehaviour
{
    public GameObject button_use;
    // Бери заготовки из скрипта PlayerInteraction
    bool isClicked; //нажата ли кнопка use
    public void TaskOnClick()
    {
        isClicked = true;
    }
    void Update()
    {
        UseControl();
        Shortcuts();
    }

    public void UseControl()
    {
        if (Namesandtypes.id == 0) //если ничего не выбрано
        {
            button_use.SetActive(false);
        }
        else
        {
            button_use.SetActive(true);
            if (isClicked)
            {
                if (Namesandtypes.id == 1 && HealthBar.fill < 0.94f) //аптечка (обычная)
                {
                    HealthBar.fill += 0.7f;
                    Backpack.medkit -= 1;
                }
                else if (Namesandtypes.id == 2) //молоко
                {
                    HealthBar.fill += 0.25f;
                    Backpack.milkpot -= 1;
                }
                else if (Namesandtypes.id == 3) //чай
                {
                    EnduranceBar.fill += 0.2f;
                    Backpack.tea -= 1;
                }
                else if (Namesandtypes.id == 4) //рыбная консерва
                {
                    EnduranceBar.fill += 0.5f;
                    Backpack.fishpot -= 1;
                }
                else
                {
                    Debug.LogError("нет объекта с таким id");
                }
                isClicked = false;
            }
        }

    }
    void Shortcuts()
    {

    }
}
