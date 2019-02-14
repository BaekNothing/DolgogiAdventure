using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterCaracter : MonoBehaviour {

    public GameObject caracterClick;
    public GameObject touchBlock;
   
    public void Awake()
    {
        caracterClick.SetActive(false);
        touchBlock.SetActive(false);
    }

    public int toggle = 0;

    public void ClickCaracter()
    {
        if (toggle == 0)
        {
            caracterClick.SetActive(true);
            touchBlock.SetActive(true);
            toggle++;
        }
        else
        {
            caracterClick.SetActive(false);
            touchBlock.SetActive(false);
            toggle--;
        }
    }

}
