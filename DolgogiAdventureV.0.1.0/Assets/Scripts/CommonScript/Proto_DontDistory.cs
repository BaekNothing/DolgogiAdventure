using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Proto_DontDistory : MonoBehaviour {
    
	void Start () {

        DontDestroyOnLoad(this.gameObject);
        
	}
	
}
