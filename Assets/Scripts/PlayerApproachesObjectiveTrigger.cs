using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerApproachesObjectiveTrigger : MonoBehaviour
{
	public Canvas ObjectiveCanvas;
	public UnityEvent Response;
	private void OnTriggerEnter(Collider other)
	{
		Response.Invoke();
	}
}
