using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenEffect : MonoBehaviour
{
    public GameObject deadImage;
    public GameObject gas_maskImage;
    public TextMeshProUGUI AttantionText;

    // Start is called before the first frame update
    void Update() 
    {
        if (HealthBar.fill<0.3f)
        {
            deadImage.SetActive(true);
            if (HealthBar.dead)
            {
                AttantionText.text = "<color=red>бш онцхакх</color>";
            }

        }
        if (HealthBar.fill >= 0.3f)
        {
            deadImage.SetActive(false);
        }
        if (EnduranceBar.fill < 0.3f && !HealthBar.dead)
        {
            AttantionText.text = "<color=yellow>менаундхлн нрднумсрэ</color>";

        }
        if (EnduranceBar.fill >= 0.3f && !HealthBar.dead)
        {
            AttantionText.text = " ";

        }
        if (Protection.gas_mask)
        {
            gas_maskImage.SetActive(true);
        }
        if (!Protection.gas_mask)
        {
            gas_maskImage.SetActive(false);
        }

    }
}
