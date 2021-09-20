using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private int nextLevelIndex;
    private Collider2D thisCollider;

    private void LoadNextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelIndex);
    }
    
    private void Start()
    {
        thisCollider = GetComponent<Collider2D>();
        thisCollider.isTrigger = true;
    }

    private void OnTriggerStay2D(Collider2D _collider2D)
    {
        if(_collider2D.gameObject == IntangibilityController.player)
        {
            LoadNextLevel();
        }
    }
}
