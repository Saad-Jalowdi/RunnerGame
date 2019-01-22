using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour {

    public Transform spawnPos;
    public static GroundSpawner ins;
    public Object[] grounds;

    private void Awake()
    {
        ins = this;
    }
    // Use this for initialization
    void Start () {
        grounds = Resources.LoadAll("Prefabs/Grounds/");            
	}
    public void Spawner()
    {
        //InvokeRepeating("Spawn",0,5);
        Spawn();
    }
    public void Spawn()
    {
        int randomIndex = Random.Range(0, grounds.Length);
        GameObject obj =(GameObject)
            Instantiate(grounds[randomIndex],
                        spawnPos.position,spawnPos.rotation);
        obj.GetComponent<GroundMovement>().Speed=GameController.ins.speed;
    }
	
	
}
