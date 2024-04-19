using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCam;
    public float interactionDistance = 10f; //расстояние до объекта

    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;
    public Image interactionIcon;



    void Update()
    {
        InteractionRay();

        if ((Input.GetKeyDown(KeyCode.F1)) && Backpack.tea > 0)
        {
            EnduranceBar.fill += 0.2f;
            Backpack.tea -= 1;
        }
        if ((Input.GetKeyDown(KeyCode.F2)) && Backpack.milkpot > 0)
        {
            HealthBar.fill += 0.25f;
            Backpack.milkpot -= 1;
        }
        if ((Input.GetKeyDown(KeyCode.F3)) && Backpack.fishpot > 0)
        {
            EnduranceBar.fill += 0.5f;
            Backpack.fishpot -= 1;
        }
    }
    void InteractionRay()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector2.one / 2f);
        RaycastHit hit;

        bool hitSomething = false;

        if (Physics.Raycast(ray, out hit, interactionDistance)) //если курсор наведён на объект
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                hitSomething = true;
                interactionText.text = interactable.GetDescription();
                interactionIcon.sprite = interactable.Geticon();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                    //Destroy(gameObject);
                }
            }
        }
        interactionUI.SetActive(hitSomething);
    }
}
