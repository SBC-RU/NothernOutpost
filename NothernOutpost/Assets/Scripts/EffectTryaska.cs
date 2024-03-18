using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTryaska : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().enabled = true;

        }
        else GetComponent<Animator>().enabled = false;

    }
}
