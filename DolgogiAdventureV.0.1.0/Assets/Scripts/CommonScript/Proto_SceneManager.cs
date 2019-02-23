using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proto_SceneManager : MonoBehaviour {
    
	//그냥 씬을 움직이려고 만든 임시 스크립트 입니다.

    //버튼의 이름을 설정하면, 해당 버튼의 마지막 숫자 만큼의 씬으로 이동합니다.
    //MoveTo"N"

    public void moveScene()
    {
        SceneManager.LoadScene( int.Parse(this.name.Substring(6, 1)) , LoadSceneMode.Single);
    }
   
}
