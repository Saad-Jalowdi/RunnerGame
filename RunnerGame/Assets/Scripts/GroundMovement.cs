using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour {


    public static GroundMovement ins;
    int speed;
    public int Speed
    {
        set { speed = value; }
        get { return speed; } 
    }

    void Awake()
    {
        ins = this;
    }

    // Update is called once per frame
    void Update () {
		transform.Translate(-Vector3.forward * speed * Time.deltaTime);
	}
}
