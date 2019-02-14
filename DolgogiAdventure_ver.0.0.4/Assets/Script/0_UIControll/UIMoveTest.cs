using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class UIMoveTest : MonoBehaviour {

    

    public GameObject rightPopup;
    public GameObject leftPopup;
    public float popupSpeed = 0.2f;
  

    private void Awake()
    {

        //rightPopup = GameObject.Find("TestSidePopup_Right");
        //leftPopup = GameObject.Find("TestSidePopup_Left");
        
        rightPopup.transform.position = new Vector3(1452f, 360f, 0f);
        leftPopup.transform.position = new Vector3(-181f, 360f, 0f);

    }

    
    public Vector2 firstPressPos;
    public Vector2 secondPressPos;
    public Vector2 currentSwipe;

    bool swifeChecker = false;

    public void Update()
    {
        
        if (swifeChecker)
        {
            if (Input.GetMouseButtonUp(0))
            {
                //save ended touch 2d point
                secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

                //create vector from the two points
                currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();

                //swipe upwards
                if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Debug.Log("up swipe");
                }
                //swipe down
                if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Debug.Log("down swipe");
                }
                //swipe left
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f && firstPressPos.x > 1210f )
                {
                    rightPopup.transform.DOMove(new Vector3(1060f, 360f, 0f), popupSpeed, false);
                    Debug.Log("left swipe_rightOn");
                    
                }

                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f && firstPressPos.x < 500f)
                {
                    leftPopup.transform.DOMove(new Vector3(-181f, 360f, 0f), popupSpeed, false);
                    Debug.Log("left swipe_leftGone");
                }

                //swipe right
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f && firstPressPos.x > 800f)
                {
                    rightPopup.transform.DOMove(new Vector3(1452f, 360f, 0f), popupSpeed, false);
                    Debug.Log("right swipe_rightGone");
                }

                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f && firstPressPos.x < 100f)
                {
                    leftPopup.transform.DOMove(new Vector3(214f, 360f, 0f), popupSpeed, false);
                    Debug.Log("right swipe_leftOn");
                }

                swifeChecker = false;

            }
            
        }

        

    }


    public void UISwife()
    {
        if (Input.GetMouseButtonDown(0) && swifeChecker == false)
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            swifeChecker = true;
        }
    }





    /* if (Input.GetMouseButtonUp(0))
     {
         //save ended touch 2d point
         secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

         //create vector from the two points
         currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

         //normalize the 2d vector
         currentSwipe.Normalize();

         //swipe upwards
         if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
     {
             Debug.Log("up swipe");
         }
         //swipe down
         if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
     {
             Debug.Log("down swipe");
         }
         //swipe left
         if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
     {
             Debug.Log("left swipe");
         }
         //swipe right
         if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
     {
             Debug.Log("right swipe");
         }
     }*/
    /*
    if (Input.touches.Length > 0)
    {
        Touch t = Input.GetTouch(0);
        if (t.phase == TouchPhase.Began)
        {
            //save began touch 2d point
            firstPressPos = new Vector2(t.position.x, t.position.y);
        }
        if (t.phase == TouchPhase.Ended)
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(t.position.x, t.position.y);

            //create vector from the two points
            currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
         {
                Debug.Log("up swipe");
            }
            //swipe down
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
         {
                Debug.Log("down swipe");
            }
            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
         {
                Debug.Log("left swipe");
            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
         {
                Debug.Log("right swipe");
            }
        }
    }*/

}
