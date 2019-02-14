using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class Assignment_Result : MonoBehaviour {

    string FrontAssignmentValueBuffer;
    string EndAssignmentValueBuffer;


    public static XmlDocument Textxml;
    public TextAsset textAsset;
    public string A;

    // Use this for initialization
    void Start () {

        FrontAssignmentValueBuffer = CaracterStatus.AssignmentValue.Substring(0, Assignment_now.assignment_now);
        EndAssignmentValueBuffer = CaracterStatus.AssignmentValue.Substring(Assignment_now.assignment_now + 1, 8 - (Assignment_now.assignment_now + 1));

        CaracterStatus.AssignmentValue = FrontAssignmentValueBuffer + this.name.Substring(6, 1) + EndAssignmentValueBuffer;

        Debug.Log(CaracterStatus.AssignmentValue);

        // 저장소에 파일이 아무것도 없을떄는 Resources에 존재하는 CaracterStatus를 읽어드린 뒤, 저장소에 저장함.
        System.IO.FileInfo directory = new System.IO.FileInfo(Application.dataPath + "/CaracterStatus.xml");
        if (!directory.Exists) { ProtoClassXMLReader.refint.Save(Application.dataPath + "/CaracterStatus.xml"); }


        // 저장가능한 장소에 저장해두고 읽어옴
        
        Textxml = new XmlDocument(); //이걸 추가해야 xml이 null하지 않음

        Textxml.Load(Application.dataPath + "/CaracterStatus.xml");
        Textxml.SelectNodes("UnitSet/UNIT/AssignmentResults")[Assignment_now.assignment_now].InnerText = this.name.Substring(6, 1);
        Textxml.Save(Application.dataPath + "/CaracterStatus.xml");
        Debug.Log(Textxml.SelectNodes("UnitSet/UNIT/AssignmentResults")[Assignment_now.assignment_now].InnerText);
        


    }


    
    }
