using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proto_Popup : MonoBehaviour {

    //임시로 만들어본 오브젝트 On / OFF 머신입니다

    public GameObject targetObject;
    
    public void popUp() {

        targetObject.SetActive(true);

    }
    
    public void popDown()
    {

        targetObject.SetActive(false);

    }

}
