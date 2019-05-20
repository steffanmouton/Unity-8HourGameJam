using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInput
{
	public static Vector3 InputReceiver
	{
		get
		{
			var input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
			return input;
		}
	}
}
