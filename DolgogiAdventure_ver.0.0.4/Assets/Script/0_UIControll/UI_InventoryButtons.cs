using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_InventoryButtons : MonoBehaviour {

    public Image InfomationImages;
    public Text InfoTitle;
    public Text InfoSubscribe;
    public Image AssignmentDegree;

    //오른쪽에 있는 작은 이미지를 클릭하면 변하는 것
    public void ClickResultImages()
    {
        //게임 시작단에 CaracterStatus.xml을 외부저장소에 저장하는 경로를 만들어 둘 것

        InfomationImages.sprite = UI_AssignmentResults.ResultSprites[int.Parse(this.name)];
        //xml데이터상에서 과제수행 결과로 인하여 저장된, CaracterStatus.xml의 AssignemntResult에 존재하는 n번째 과제의 결과값에 따라서, Sprite를 교체함
        AssignmentDegree.sprite = UI_AssignmentResults.ResultDegree[int.Parse(Assignment_Result.Textxml.SelectNodes("UnitSet/UNIT/AssignmentResults")[int.Parse(this.name)].InnerText)];   
    }
}

