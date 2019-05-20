using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

	public Vector3 CurrentVector;
	public Transform SpawnPoint;
	public float Speed;
	

	private void Start()
	{
		CurrentVector = Vector3.left;
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
