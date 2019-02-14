using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {
    
    public GameObject thisParentsObject;
    public string parentsName;

	// Use this for initialization
	void Start () {
        
        //닫고싶은 창 이름 + ExitButton을 가진 버튼을 만든 뒤, 해당 창 하위 카테고리로 만들어 놓으면 알아서 끔

        parentsName = this.gameObject.name.ToString();

        
        parentsName = parentsName.Replace("ExitButton",null);
        thisParentsObject = GameObject.Find(parentsName);
		
	}
	
	// Update is called once per frame
	public void ExitClicked () {
        
        thisParentsObject.SetActive(false);
       
    }
}
