using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	/// <summary>
	/// this will reload the current level
	/// </summary>
	private void ReloadLevel()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
	}
	
	private void OnCollisionEnter2D(Collision2D _collision)
	{
		// if the player collides, reload the level
		if(_collision.collider.gameObject == IntangibilityController.player)
		{
			ReloadLevel();
		}
	}

	private void OnCollisionStay2D(Collision2D _collision)
	{
		// if the player collides, reload the level
		if(_collision.collider.gameObject == IntangibilityController.player)
		{
			ReloadLevel();
		}
	}
}
