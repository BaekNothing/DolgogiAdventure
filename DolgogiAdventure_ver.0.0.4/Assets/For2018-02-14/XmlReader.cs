using System;
using UnityEngine;
using System.Collections;
using System.Xml;

public class XmlReader : MonoBehaviour

{
    //어떤 글자를 만들건데, 그 이름은 Book1이야
    public string _fileName = "Database";

    public static int testText = 25;
    
    public XmlDocument refint;

    public static XmlNodeList Voters;
    public static XmlNodeList Publishers;

    public string[] VoterList = new string[13];
    public string[] PublisherList = new string[13];


    void Awake()
    {   
        //Xme_Load를 실행시키되 _fileName이라는 변수를 넣어서 실행하겠다
        Xme_Load(_fileName, ref refint);

        Voters = refint.GetElementsByTagName("Voter");
        Publishers = refint.GetElementsByTagName("Publisher");
        /*
        //전체 다 이용하는 법 
        XmlNodeList nodes = refint.SelectNodes("UnitSet/UNIT");

        int listNumber = 0;

        foreach (XmlNode node in nodes)
        {
            Debug.Log("Voter : " + node.SelectSingleNode("Voter").InnerText);
            VoterList[listNumber] = node.SelectSingleNode("Voter").InnerText;
            Debug.Log("Publisher : " + node.SelectSingleNode("Publisher").InnerText);
            PublisherList[listNumber] = node.SelectSingleNode("Publisher").InnerText;

            listNumber++;
        }
        */
    }

    //Xme_Load가 뭐냐면
    public static XmlDocument Xme_Load(string Filename, ref XmlDocument refint )
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
