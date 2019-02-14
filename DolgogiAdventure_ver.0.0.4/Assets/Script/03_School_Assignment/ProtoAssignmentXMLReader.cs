using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;



//학기정보를 저장하는 변수
public static class ProtoAssignmentData
{
    //push pop pull으로 컨트롤할 수 있는 Stack구조
    public static Stack<string> AssignmentStack = new Stack<string>();

    public static XmlNodeList Nodes;
}


class ProtoAssignmentXMLReader : MonoBehaviour
{
    //이 글자를 변형시키면 다른 XML데이터를 읽어오는것도 가능
    public string _fileName = "AssignmentInfo";

    public XmlDocument refint;
    
    public static XmlNodeList Names;

    public string[] testSingleNodeTostring = new string[10];

    void Awake()
    {
        //Xme_Load를 실행시키되 _fileName이라는 변수를 넣어서 실행하겠다
        Xme_Load(_fileName, ref refint);
        
        //이 스크립트는, 게임이 시작될때 Nodes라는 전역변수에 XML을 집어넣는다(파일명 _fileName, 
        ProtoAssignmentData.Nodes = refint.SelectNodes("UnitSet/UNIT");

        // -------------- 여기 아래부터는 순전히 디버그용 ------------------

        Names = refint.GetElementsByTagName("ClassnameForDebug");

        Debug.Log(Names[0].InnerText);

        //Name으로 탐색하기 테스트
        for (int a = 0; a < 10; a++)
        {
            if (ProtoAssignmentData.Nodes[a] != null)
            {
                testSingleNodeTostring[a] = ProtoAssignmentData.Nodes[a].InnerText;
            }
        }

    }

    //Xml을 로드하는 메소드
    public static XmlDocument Xme_Load(string Filename, ref XmlDocument refint)
    {
        //텍스트에셋을 선언할건데, 이게 뭐냐면, Resources폴더속 XML폴더 안에있는 어떤 파일을 실핻시켜서 적용시킬건데, 그 파일 이름은 아까 실행할때 선언했어
        TextAsset textAsset = (TextAsset)Resources.Load("XML/ProtoClassData/" + Filename);

        //Xml도큐먼트를 만들어서, 아까 불러온 TextAsset에서 텍스트 부분만 가져와 적용시킬거야.
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.LoadXml(textAsset.text);

        refint = xmldoc;

        return refint;
    }


}