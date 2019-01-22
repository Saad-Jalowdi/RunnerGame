using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {
    public float maxTime;
    public float minSwipeDi;

    float startTime;
    float endTime;

    Vector3 startPos;
    Vector3 endPos;

    float swipeDistance;
    float swipeTime;

    // Use this for initialization
    void Start () {
		
	}
	
    // Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        { 
        startTime = Time.time;
        startPos = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            endTime = Time.time;
            endPos = Input.mousePosition;
            swipeDistance = (endPos - startPos).magnitude;
            Debug.Log("swipeDistance"+swipeDistance);
            swipeTime = endTime - startTime; 
            if(swipeTime < maxTime && swipeDistance > minSwipeDi)
            {
                swipeMethod();
            }
        }
	}
    public void swipeMethod()
    {
        Vector2 distance = endPos - startPos; 
        if(Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
        {
            if (distance.x > 0)
            {
                Debug.Log("Swipe right");
                PlayerController.ins.MoveRight();
            }
            if (distance.x < 0)
            {
                Debug.Log("Swipe left");
                PlayerController.ins.MoveLeft();
            }
        }else if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
        {
            if (distance.y > 0)
            {
                Debug.Log("Swipe up");
                PlayerController.ins.Jump();
            }
            if (distance.y < 0)
                Debug.Log("Swipe down");
                if(PlayerController.ins.isGrounded)
                PlayerController.ins.anim.SetTrigger("roll");
               }
    }
}
