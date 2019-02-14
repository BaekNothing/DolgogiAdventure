using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRightControll : MonoBehaviour {
    

    public void CaracterInfo()
    {

    }

    public Slider caracterWill;
    public Slider caracterSociability;
    public Slider caracterSelfego;

    public void Start()
    {

        caracterWill.value = CaracterStatus.caracterWill;
        caracterSociability.value = CaracterStatus.caracterSociability;
        caracterSelfego.value = CaracterStatus.caracterSelfego;
    }

}
