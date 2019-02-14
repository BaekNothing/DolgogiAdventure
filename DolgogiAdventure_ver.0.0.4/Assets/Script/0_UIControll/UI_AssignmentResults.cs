using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_AssignmentResults : MonoBehaviour {


    // Assignment 결과창이 활성화 된 이후에 작동하는 것

    // 오른쪽에 있는 작은 이미지들 8개 
    public static Sprite[] ResultSprites = new Sprite[8];
    public static Sprite[] ResultDegree = new Sprite[6];


    public Image[] ResultImages = new Image[8];
    public GameObject[] ResultButtons = new GameObject[8];
    public Text[] ResultTexts = new Text[8];

    private void Start()
    {
        //리소스에 모아진 것들을 한번에 모두 로드하는 기능 (선언량에 상관없이 Load되는 길이에 맞춰짐)
        ResultSprites = Resources.LoadAll <Sprite> ("Image/Testdata/Do_Assignment/AssignmentResults");
        ResultDegree = Resources.LoadAll<Sprite>("Image/Testdata/Do_Assignment/AssignmentResultsDegree");

        for (int a = 0; a<8; a++)
        {
            //스프라이트를 해당 인수로 교체 (결과 스프라이트는, XML데이터에 따라 불러오도록 변경할 것)
            ResultImages[a].sprite = ResultSprites[a];
            
            //버튼에 해당 과제 정보를 이름으로 저장할 것 
            ResultButtons[a].name = a.ToString();

        }
    }



}
