using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment_DoAnimation : MonoBehaviour {

    public GameObject[] Results = new GameObject[3];

    int RandomValue;
    float Timer;

	// Use this for initialization
	void Start () {

        // 애니메이션 하단부 텍스트는 ClassXML정보에서 추출해서 대입할 것

        RandomValue = Random.Range(0, 100);
        


	}
	
    void SummitButton()
    {
        // 나중에, 확인 클릭하면 넘어가는 버튼도 만들 것

    }

    // 애니메이션을 몇초간 보여준 뒤, 스테이터스에 따라 결과물을 만들어냄
	// Update is called once per frame
	void Update () {

        Timer = Timer + Time.deltaTime;


        //2초 뒤에 결과값에 따라서 등급을 저장해두는건데, 너무 임시방편이라 추후에 다듬을 것
        if(Timer > 2.0)
        {
             if (RandomValue < 30) { Results[0].SetActive(true); }
             else if (RandomValue < 60) { Results[1].SetActive(true); }
             else { Results[2].SetActive(true); }
        }

	}
}
