using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class EnemyDamagePlayerOnContact : MonoBehaviour {
	private void OnCollisionEnter(Collision other)
	{
		if (!other.gameObject.CompareTag("Player")) return;
		
		var PlayerInfo = other.gameObject.GetComponent<PlayerBehaviour>();

		if (PlayerInfo.isHidden)
			return;

		PlayerInfo.HP--;
		other.gameObject.GetComponent<Transform>().position =
			other.gameObject.GetComponent<PlayerBehaviour>().LastCheckpoint.position;
	}
}
