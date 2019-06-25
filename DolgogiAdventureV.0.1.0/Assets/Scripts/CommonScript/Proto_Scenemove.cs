using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proto_Scenemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    public void Click0()
    {
        SceneManager.LoadScene(1);

    }

    public void Click1()
    {
        SceneManager.LoadScene(2);

    }


    public void Click2()
    {
        SceneManager.LoadScene(3);

    }


}
