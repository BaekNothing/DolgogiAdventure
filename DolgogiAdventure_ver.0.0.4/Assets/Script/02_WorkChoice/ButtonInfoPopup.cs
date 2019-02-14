using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonInfoPopup : MonoBehaviour {

    public GameObject PopupPanel;
    public GameObject TouchBlock;
    public Vector2 Touchvector;
    public Vector2 NormalPopupVector;
   
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;

    // 버튼을 누를때 (활성화시킬때 변화하는 부분들을 다룹니다)
    private void Awake()
    {
        Option1.SetActive(false);
        Option2.SetActive(false);
        Option3.SetActive(false);

        TouchBlock.SetActive(false);
        NormalPopupVector = new Vector2(222f, 170f);
       
        PopupPanel.transform.position = new Vector2(300f, -300f);
    }

    public void Clicked()
    {
        TouchBlock.SetActive(true);
        Touchvector = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        PopupPanel.transform.position = Touchvector + NormalPopupVector;

        GameObject.Find("ChoicePopup").SendMessage("TodoNameReceiver", this.name);
    }

    public void OptionClicked()
    {
        TouchBlock.SetActive(true);

        Touchvector = new Vector2(Input.mousePosition.x - 150f, Input.mousePosition.y + 100f);

        PopupPanel.transform.position = Touchvector;
    }

}
