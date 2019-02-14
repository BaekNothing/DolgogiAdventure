using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _GameExit : MonoBehaviour {
    

    //객채 지향 프로그래밍 

    public GameObject ExitPanel;

    bool ExitChecker;

    private void Awake()
    {

        ExitChecker = true;
        ExitPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (ExitChecker == true)
                ExitPanel.SetActive(true);
            else
                ExitPanel.SetActive(false);

            ExitChecker = !ExitChecker;

        }

    }

    public void ExitButtonPressed()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void ExitPanelShutdown()
    {
        ExitChecker = !ExitChecker;
        ExitPanel.SetActive(false);
    }

}
