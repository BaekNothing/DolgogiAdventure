using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCicle : MonoBehaviour {
    
    public void MainToFirst()
    {
        SceneManager.LoadScene(CaracterStatus.NowScene + 1, LoadSceneMode.Single);

        CaracterStatus.NowScene++;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(CaracterStatus.NowScene + 1, LoadSceneMode.Single);

        CaracterStatus.NowScene++;
    }

    public void PrevScene()
    {

        SceneManager.LoadScene(CaracterStatus.NowScene - 1, LoadSceneMode.Single);

        CaracterStatus.NowScene--;
    }

    public void ReturnToSceneZero()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);

        CaracterStatus.NowScene = 1;
    }


}
