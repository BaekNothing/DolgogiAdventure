using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click : MonoBehaviour {
    
    public Camera mainCamera;
    RaycastHit rayCastHit;

    private void Awake()
    {

    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Ray Clickray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Clickray, out rayCastHit, Mathf.Infinity))
            {

                Debug.Log("RayCastStart");
                if (rayCastHit.collider.tag == null)
                { Debug.Log("null"); }
                else
                {
                    try
                    {
                        Debug.Log("Clicked");
                        rayCastHit.collider.gameObject.SendMessage("Clicked",SendMessageOptions.DontRequireReceiver);
                    }
                    catch
                    {
                        Debug.Log("Fail");
                    }
                }
            }
        }
	}
}
