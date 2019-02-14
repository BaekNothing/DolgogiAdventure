using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfoPopDown : MonoBehaviour {

    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;

    public GameObject TouchBlock;
    public Vector2 NontouchVector = new Vector2(300f, -300f);

    //활성화된 판넬에서 상호작용 한 결과물 (창이 닫히거나) 하는 부분들을 다룹니다.
    public void Submit()
    {
        TouchBlock.SetActive(false);
        this.transform.position = NontouchVector;
        Debug.Log(this.name);
        this.SendMessage("OptionAwake");
    }

    public void Cancle()
    {
        TouchBlock.SetActive(false);

        this.transform.position = NontouchVector;
    }

    public void TodoNameReceiver(string receivedname)
    {
        Debug.Log(receivedname);

        Option1 = GameObject.Find(receivedname).transform.Find(receivedname + "_Option(0)").gameObject;
        Option2 = GameObject.Find(receivedname).transform.Find(receivedname + "_Option(1)").gameObject;
        Option3 = GameObject.Find(receivedname).transform.Find(receivedname + "_Option(2)").gameObject;

    }

    public void OptionAwake()
    {
        Option1.SetActive(true);
        Option2.SetActive(true);
        Option3.SetActive(true);

        Debug.Log("sended");
    }

}
