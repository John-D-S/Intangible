using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    [SerializeField] private Vector2 boundsSize;

    /// <summary>
    /// will return whether or not the position given is inside the bounds
    /// </summary>
    public bool PositionIsOutOfBounds(Vector2 _position)
    {
        //this is the given position relative to this gameobject.
        Vector2 relativeLocalPosition = transform.worldToLocalMatrix * (transform.position - (Vector3)_position);
        //if the position is within the bounds, return true 
        return Mathf.Abs(relativeLocalPosition.x) < boundsSize.x * 0.5f && Mathf.Abs(relativeLocalPosition.y) < boundsSize.y * 0.5f;
    }

    private void OnDrawGizmos()
    {
        //draw the bounds as a box
        Gizmos.color = Color.red;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, boundsSize);
    }
}