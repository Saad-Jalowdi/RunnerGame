using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController ins;
    public int speed = 5;

    private void Awake()
    {
        ins = this;
    }
    // Use this for initialization
    void Start () {
		Invoke("StartGame",2);                     
	}
    void StartGame()
    {
        GameObject[] grounds = GameObject.FindGameObjectsWithTag("Ground");
        for (int i = 0; i < grounds.Length; i++)
        {
            grounds[i].GetComponent<GroundMovement>().Speed = speed;
        }
        GroundSpawner.ins.Spawner();
    }
}
