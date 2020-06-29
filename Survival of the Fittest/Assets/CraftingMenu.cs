using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingMenu : MonoBehaviour
{
    public bool isVisible = false;
    public GameObject crafting;

    void Update()
    {
        if(Input.GetKeyDown("q") && isVisible == false)
        {
            crafting.SetActive(true);
            isVisible = true;
            Debug.Log("ok");
        }
        else if(Input.GetKeyDown("q") && isVisible == true)
        {
            crafting.SetActive(false);
            isVisible = false;
            Debug.Log("ok");
        }
    }
}