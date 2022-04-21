using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
	public void OnCollisionEnter(Collision other)
	{
		Debug.Log(other);
		SceneManager.LoadScene("MainMenu");
		switch (other.collider.tag)
		{
			case "Player":
				Cursor.visible = true;
				SceneManager.LoadScene("MainMenu");
				break;
		}
	}
}
