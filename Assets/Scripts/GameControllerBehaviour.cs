using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerBehaviour : MonoBehaviour {

	public void QuitGame()
	{
		Application.Quit();
	}

	public void ResetGame()
	{
		SceneManager.LoadScene("0.main");
	}

	private void Update()
	{
		if (Input.GetButton("Escape"))
		{
			Application.Quit();
		}
	}
}
