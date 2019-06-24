using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Assignment_now
{
    //어느 수업의 과제를 하고있는지 저장하는 변수 > 과제의 종류는 ClassInfo.xml / Assignment에서 결정됩니다.
    public static int assignment_now;

}

public class Assignment_FirstBookControll : MonoBehaviour {


    public GameObject AssignmentChoicePopup;
    // 한학기에 최대로 들을 수 있는 수업의 갯수는 7개정도? 가 될테니까,넉넉잡아 8개정도 만들어 둡니다.
    public GameObject[] AssignmentChoiceMark = new GameObject[8];
    public int ChooseAssignmentNumber;
        
    //설정된 과목과 과제에 대한 설명
    void AssignmentDiscrive()
    {


    }

    // Use this for initialization
    void Start () {

        // 이번주의 과제 여부에 따라서 (0이 아닐 경우에) 페이지를 선택적으로 활성화
        // Class정보에서 Assignment여부를 체크할 것

        // Class정보에서 Assignment부분 중, 한 주의 내용을 뽑아냄 (XMLReader에서 Static부분이 굳이 필요한지 의문스러움)
        Debug.Log(ProtoClassXMLReader.refint.SelectNodes("UnitSet/UNIT/Assignments")[0].InnerText.ToString().Substring(0,1));

        SetAssignment(CaracterStatus.Day);

        AssignmentChoicePopup.SetActive(true);
	}


    //활성화된 Assignment에 따라 mark를 활성화한다(해당 Assignment페이지로 넘어갈 수 있는 버튼 활성화)
    void SetAssignment( int Day )
    {

        string[] AssignmentsArray = new string[8];

        //Assignments값을 추출하여 Array에 집어넣습니다 (12자리의 숫자로 추출됨)
        for (int a = 0; a < 8; a++)
        {
            if(ProtoClassXMLReader.refint.SelectNodes("UnitSet/UNIT/Assignments")[a] != null)
            AssignmentsArray[a] = ProtoClassXMLReader.refint.SelectNodes("UnitSet/UNIT/Assignments")[a].InnerText;
        }

        for (int a = 0; a<8; a++)
        {
            //추출한 문자열에서 Day번째에 있는 숫자 1개를 추출하여 0이 아니면 (=과제가 있으면) 과제 페이지 호출

            if (AssignmentsArray[a] != null)
            {
                if (int.Parse(AssignmentsArray[a].Substring(Day, 1)) != 0)
                {
                    Debug.Log(a.ToString() + "번째에 접근");
                    //Mark를 내가 만들었는지 확인
                    if (AssignmentChoiceMark[a] != null)
                        AssignmentChoiceMark[a].SetActive(true);
                }
            }
        }
    }
}


