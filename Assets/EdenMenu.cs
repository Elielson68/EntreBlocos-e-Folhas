using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdenMenu : MonoBehaviour
{
    public GameObject LareiraStep;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            LareiraStep.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
