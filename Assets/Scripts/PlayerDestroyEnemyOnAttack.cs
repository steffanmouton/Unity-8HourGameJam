using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyEnemyOnAttack : MonoBehaviour {
	private void OnTriggerStay(Collider other)
	{
		if (!other.CompareTag("Enemy")) 
			return;
		if (Input.GetButtonDown("Fire1"))
		{
			Destroy(other.gameObject);
		}
	}
}
