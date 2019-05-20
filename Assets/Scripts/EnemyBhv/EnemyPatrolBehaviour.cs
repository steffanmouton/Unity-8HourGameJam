using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EnemyPatrolBehaviour : MonoBehaviour
{
	public EnemyBehaviour eb;

	public float PatrolTime = 2f;

	public float Timer;
	public Vector3 EnemyVisionBoxCenter;
	// Use this for initialization
	void Start ()
	{
		eb = GetComponent<EnemyBehaviour>();
		EnemyVisionBoxCenter = new Vector3(-2, 0, 0);
		Timer = PatrolTime;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += eb.CurrentVector * eb.Speed * Time.deltaTime;
		if (Timer < 0)
		{
			eb.CurrentVector *= -1;
			Timer = PatrolTime;
			GetComponentInChildren<SpriteRenderer>().flipX = !GetComponentInChildren<SpriteRenderer>().flipX;
			if (GetComponentInChildren<SpriteRenderer>().flipX)
				GetComponent<BoxCollider>().center = EnemyVisionBoxCenter;
			else
				GetComponent<BoxCollider>().center = EnemyVisionBoxCenter * -1;
		}

		Timer -= Time.deltaTime;
	}
}
