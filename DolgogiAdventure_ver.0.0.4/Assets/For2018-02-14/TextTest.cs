using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;

public class TextTest : MonoBehaviour {

    
    public string[] PublisherList = new string[13];
    public string[] RandomBox = new string[24];
    public string[] ChoiceList = new string[24];
    
	// Use this for initialization
	void Start () {
        
        PublisherList = new string[] { "김나연","김규빈","김은후","김태인","김휘성","오지현",
                                       "조다혜","안유정","김윤진","이수연","임현지","박상원","신재용"};
        
        
        int randomNumber = 0;
        
        foreach(string n in PublisherList)
        {
            RandomNumber(ref randomNumber);
            RandomBox[randomNumber] = n;
        }
        
        foreach (XmlNode n in XmlReader.Publishers)
        {
            RandomNumber(ref randomNumber);
            RandomBox[randomNumber] = n.InnerText;
        }

        ChoiceList[0] = RandomBox[0];
    }

    public int Number = 1;
    public int Minus = 1;
    public int Counter = 1;
    public int trueFalse = 0;
    public int stoper = 0;

    private void Update()
    {
        while (stoper == 0) { 
        while (Number >= Minus)
        {
            if (RandomBox[Number] == RandomBox[Number - Minus])
            {
                Minus = Number+1; trueFalse = 0; 
            }
            else { Minus++; trueFalse = 1; }
            
        }

        if (trueFalse == 1)
        {    
            ChoiceList[Counter] = RandomBox[Number];
            Counter++;
        }

        Minus = 1;
        Number++;

        if(Number > 20)
        { stoper = 1; }
        }
    }

    public Text Chosen1;
    public Text Chosen2;
    public Text Chosen3;
    public Text Chosen4;

    public void Click()
    {
        Chosen1.text = ChoiceList[0];
        Chosen2.text = ChoiceList[1];
        Chosen3.text = ChoiceList[2];
        Chosen4.text = ChoiceList[3];
    }


    int RandomNumber(ref int randomNumber)
    {
        randomNumber = Random.Range(0, 24);
        if (RandomBox[randomNumber] != "")
        { RandomNumber(ref randomNumber); }
        
        return randomNumber;
    }

}
