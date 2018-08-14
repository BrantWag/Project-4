using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;

    private ControllerPlayer player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<ControllerPlayer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RespawnPlayer()
    {
        Debug.Log("Player Respwan");
        player.transform.position = currentCheckpoint.transform.position; 
    }
}
