using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIControllerBehaviour : MonoBehaviour
{

	public UnityEvent Response;

	private void Update()
	{
		Response.Invoke();
	}
}
