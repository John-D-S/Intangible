using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField, Tooltip("The scene build index of the scene to load when the player enters the trigger zone.")] private int nextLevelIndex;
    private Collider2D thisCollider;

    /// <summary>
    /// loads the scene with the index nextLevelIndex
    /// </summary>
    private void LoadNextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelIndex);
    }
    
    private void Start()
    {
        //initialise the collider and set it to be a trigger
        thisCollider = GetComponent<Collider2D>();
        thisCollider.isTrigger = true;
    }

    private void OnTriggerStay2D(Collider2D _collider2D)
    {
        //if the player comes into the trigger zone, load the next level
        if(_collider2D.gameObject == IntangibilityController.player)
        {
            LoadNextLevel();
        }
    }
}
