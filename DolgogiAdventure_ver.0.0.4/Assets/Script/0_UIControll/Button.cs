using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject ButtonPanel;

    private void Awake()
    {
        //Shutdowns

        ButtonPanel.SetActive(false);

    }

    public void Clicked()
    {
        ButtonPanel.SetActive(true);
        //나중에 사운드도 추가할것?
    }

}
