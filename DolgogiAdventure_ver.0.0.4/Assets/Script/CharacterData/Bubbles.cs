using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bubbles : MonoBehaviour {

    public GameObject[] caracterBubble = new GameObject[6];

    


    // Use this for initialization
    void Awake () {


        // for test
        CaracterStatus.condition[0] = 1;
        CaracterStatus.condition[2] = 2;
        CaracterStatus.condition[3] = 4;


        for (int i = 0; i < 6; i++)
        {
            if ( caracterBubble[i] != null )
            { 
            caracterBubble[i].SetActive(false);
            }
        }
    }


    public void BubbleClicked()
    {  
        for (int i = 0; i < 6; i++)
        {
            if (caracterBubble[i] != null)
            {
                if ( CaracterStatus.condition[i] != 0 )
                {
                    caracterBubble[i].SetActive(true);
                    Bubbletext( caracterBubble[i], i );
                }
                else
                { caracterBubble[i].SetActive(false); }
            }
        }
    }

    

    public void Bubbletext( GameObject caracterBubble, int i )
    {
        Text bubbletext = caracterBubble.transform.GetChild(0).GetComponent<Text>();

        //나중에 i의 순서에 따른 외부 text를 읽게 할 것
        if (CaracterStatus.condition[i] == 1) { bubbletext.text = "매우 나쁜 상태이다"; }
        if (CaracterStatus.condition[i] == 2) { bubbletext.text = "나쁜 상태이다"; }
        if (CaracterStatus.condition[i] == 3) { bubbletext.text = "좋은 상태이다"; }
        if (CaracterStatus.condition[i] == 4) { bubbletext.text = "매우 좋은 상태이다"; }
    }


}
