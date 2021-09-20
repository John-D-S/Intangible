using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOutOfBounds : MonoBehaviour
{
    [SerializeField] private Bounds bounds;
    private bool isInsideBounds = false;
    
    private void FixedUpdate()
    {
        isInsideBounds = bounds.PositionIsOutOfBounds(transform.position);
        //reloads the scene if out of bounds
        if(!isInsideBounds)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }
}