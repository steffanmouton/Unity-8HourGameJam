using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
	public Transform PlayerSpawnPoint;
	public Transform PlayerTransform;
	public Transform LastCheckpoint;

	public float PlayerSpeed = 1;

	public float SprintSpeed = 5;

	public bool isHidden;


	public int HP = 3;
	// Use this for initialization
	void Start ()
	{
		transform.position = PlayerSpawnPoint.position;
		LastCheckpoint = PlayerSpawnPoint;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
