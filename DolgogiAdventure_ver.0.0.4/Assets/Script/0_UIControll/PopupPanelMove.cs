using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPanelMove : MonoBehaviour {


    static int nowPanelNumber;
    public GameObject[] popupPanels = new GameObject[4];

    public void Start()
    {
        nowPanelNumber = 0;
        popupPanels[0].SetActive(true);
        popupPanels[1].SetActive(false);
        popupPanels[2].SetActive(false);
        popupPanels[3].SetActive(false);
    }

    public void ClickNext()

    {
        
        if (nowPanelNumber == 3) { }
        else
        {
            popupPanels[nowPanelNumber].SetActive(false);
            nowPanelNumber++;
            popupPanels[nowPanelNumber].SetActive(true);
        }


    }

    public void ClickPrev()
    {
        if (nowPanelNumber == 0) { }
        else
        {
            popupPanels[nowPanelNumber].SetActive(false);
            nowPanelNumber--;
            popupPanels[nowPanelNumber].SetActive(true);
        }
    }

}
