using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;


// 2019_1_27일자로 이 스크립트는 legacy_ClassChoice에만 사용됨
// XML은 Assignment에서 읽습니다.


//학기정보를 저장하는 변수
public static class ThisSemesterdata {

    //한학기 최대 9개의 Class string[0,n]은 각 항목 이름으로 쓰인다
    public static string[] Classes = new string[10];
    public static Stack<string> ClassStack = new Stack<string>();

    public static XmlNodeList ClassNodes;
}


class ThisSemester : MonoBehaviour
{
    //이 글자를 변형시키면 다른 XML데이터를 읽어오는것도 가능
    public string _fileName = "TestClass";
    
    public XmlDocument refint;

    public static XmlNodeList Names;
    
    public string[] testSingleNodeTostring = new string[10];

    void Awake()
    {
        //Xme_Load를 실행시키되 _fileName이라는 변수를 넣어서 실행하겠다
        Xme_Load(_fileName, ref refint);

        //이 스크립트는, 게임이 시작될때 ClassNodes라는 전역변수에 XML을 집어넣는다(파일명 _fileName, 
        ThisSemesterdata.ClassNodes = refint.SelectNodes("UnitSet/UNIT");



        // -------------- 여기 아래부터는 순전히 디버그용 ------------------

        Names = refint.GetElementsByTagName("ClassName");

        testSingleNodeTostring[0] = Names[0].InnerText;
        
        //4목 - 01031598241디지털 미디어김정훈
        for (int a = 0; a < 4; a++)
        { 
            if("디지털 미디어" == Names[a].InnerText)
            {
                testSingleNodeTostring[2] = ThisSemesterdata.ClassNodes[a].InnerText;
                a = 10;
            }
        }
        //5금 - 01059512480인터렉션 융합양승무
        testSingleNodeTostring[0] = ThisSemesterdata.ClassNodes[0].InnerText;
        //2화 - 01045914820인터렉션 스튜디오김정훈
        testSingleNodeTostring[1] = ThisSemesterdata.ClassNodes[1].InnerText;
        
    }

    //Xml을 로드하는 메소드
    public static XmlDocument Xme_Load(string Filename, ref XmlDocument refint)
    {
        //텍스트에셋을 선언할건데, 이게 뭐냐면, Resources폴더속 XML폴더 안에있는 어떤 파일을 실핻시켜서 적용시킬건데, 그 파일 이름은 아까 실행할때 선언했어
        TextAsset textAsset = (TextAsset)Resources.Load("XML/" + Filename);

        //Xml도큐먼트를 만들어서, 아까 불러온 TextAsset에서 텍스트 부분만 가져와 적용시킬거야.
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.LoadXml(textAsset.text);

        refint = xmldoc;

        return refint;
    }


}