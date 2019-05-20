using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIGameOverController : MonoBehaviour {

	public GameObject Player;
	public UnityEvent Response;

	public Canvas GameOverScreen;
	// Update is called once per frame
	void Update () {
		if (Player.GetComponent<PlayerBehaviour>().HP < 1)
		{
			Response.Invoke();
		}
	}
}
