using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBehaviour : MonoBehaviour
{
	public PlayerBehaviour pb;
	// Update is called once per frame
	void Update ()
	{
		var speed = pb.PlayerSpeed;
		var moveVector = new Vector3(PlayerInput.InputReceiver.x, 0).normalized;
		if (Input.GetKey(KeyCode.LeftShift))
		{
			speed = pb.SprintSpeed;
		}
		transform.position += moveVector * speed * Time.deltaTime;

		var animator = GetComponent<Animator>();
		animator.SetFloat("Input", Input.GetAxis("Horizontal"));
	}
}
