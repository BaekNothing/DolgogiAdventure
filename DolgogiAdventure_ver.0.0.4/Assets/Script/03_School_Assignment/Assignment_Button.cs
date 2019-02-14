using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment_Button : MonoBehaviour
{


    //과제를 수행하는 모습
    public GameObject[] DoAssignmentAnimation = new GameObject[8];

    //마크선택을 통한 페이지팝업 (총 8개니 넉넉하게 9개준비)
    public GameObject[] AssignmentPages = new GameObject[9];
    public GameObject TotalAssignmentPage;

    // Assignmnet_now에 값을 넘겨주고, 애니메이션을 실행시킵니다.
    public void DoAssignmentAnimationButton()
    {
        //FirstBookControll에 있는 Class // 어느 수업의 과제를 하는지 정의합니다.
        Assignment_now.assignment_now = int.Parse(this.name.Substring(4,1));

        TotalAssignmentPage.SetActive(false);

        //"해당 버튼의 뒷번호와 Caracter-Day값에 해당하는 ClassXml-Assignment값"의 번호를 가진 Animation을 활성화시킨다.
        DoAssignmentAnimation[int.Parse(ProtoClassXMLReader.refint.SelectNodes("UnitSet/UNIT/Assignments")[int.Parse(this.name.Substring(4, 1))].InnerText.Substring(CaracterStatus.Day, 1))].SetActive(true);
    }
    

    // 과제 옆 책갈피를 누르면 해당 책갈피에 맞는 과제 페이지가 활성화 됩니다.
    public void AssignmentMarkButton()
    {
        for (int a = 0; a < 8; a++)
        {  if(AssignmentPages[a] != null) AssignmentPages[a].SetActive(false);  }

        AssignmentPages[int.Parse(this.name.Substring(4, 1))].SetActive(true);
    }
}
