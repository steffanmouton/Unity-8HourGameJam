using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MakePlayerHiddenOnEnter : MonoBehaviour {
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponent<PlayerBehaviour>().isHidden = true;
			other.GetComponent<Rigidbody>().isKinematic = true;
			other.GetComponent<PlayerBehaviour>().LastCheckpoint = transform;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponent<PlayerBehaviour>().isHidden = false;
			other.GetComponent<Rigidbody>().isKinematic = false;
		}
	}
	
	
}
