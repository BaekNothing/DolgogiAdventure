using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorswap : MonoBehaviour {

    Color newcolor = new Color(225, 0, 0);

    public SpriteRenderer spriteRenderer;


	// Use this for initialization
	void Start () {

        spriteRenderer.GetComponent<SpriteRenderer>();
        spriteRenderer.color = newcolor;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
