using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthCounter : MonoBehaviour
{

	public GameObject Player;
	public Image HP1;
	public Image HP2;
	public Image HP3;
	// Update is called once per frame
	void Update ()
	{
		var hp = Player.GetComponent<PlayerBehaviour>().HP;
		if (hp < 3)
		{
			HP3.enabled = false;
		}
		if (hp < 2)
		{
			HP2.enabled = false;
		}
		if (hp < 1)
		{
			HP1.enabled = false;
		}
	}
}
