using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassChoiceButton : MonoBehaviour {
    

    //CaracterStatus ThisSemester 스크립트에 전적으로 의지함
    public Text Buttontext;
    public bool ClickChecker = true;
    public int Fortryparse;

    private void Start()
    {
        if( int.TryParse(this.name.Substring(this.name.Length - 1), out Fortryparse))
        { 
            //버튼의 텍스트 설정
            Buttontext.text = ThisSemesterdata.ClassNodes[Fortryparse].InnerText;
        }
    }

    public void ClickClassButton()
    {
         //클릭하면 스택쌓기
        if (ClickChecker)
        {
            //해당 버튼의 맨 뒤에있는 숫자가 XML데이터 상의 위치번호 (0부터 시작함)
            ThisSemesterdata.ClassStack.Push(ThisSemesterdata.ClassNodes[int.Parse(this.name.Substring(this.name.Length - 1))].InnerText);
            
            //버튼을 누르면 색상이 변함
            this.GetComponent<Image>().color = new Color(0, 144, 60);

        }
        else
        {

            ThisSemesterdata.ClassStack.Pop();
            Debug.Log("Poped");

            //다시 누르면 흰색으로 돌아옴
            this.GetComponent<Image>().color = new Color(255, 255, 255);

        }

        ClickChecker = !ClickChecker;
    }

    public void CancleClassButton()
    {

        ThisSemesterdata.ClassStack.Pop();

    }

    public GameObject FinishPopup;

    public void ClassChoiceFinish()
    {
        FinishPopup.SetActive(true);
    }

    public void ClassChoiceSubmit()
    {
        int stackLangth = ThisSemesterdata.ClassStack.Count;

        while (stackLangth > 0)
        {
            ThisSemesterdata.Classes[stackLangth] = ThisSemesterdata.ClassStack.Pop();
            Debug.Log(ThisSemesterdata.Classes[stackLangth]);
            stackLangth--;
        }

        Debug.Log("이전완료");
    }

    public void ClassChoiceCancle()
    {
        FinishPopup.SetActive(false);
    }

}
