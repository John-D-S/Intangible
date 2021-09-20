using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    [SerializeField] private Vector2 boundsSize;

    public bool PositionIsOutOfBounds(Vector2 _position)
    {
        Vector2 relativeLocalPosition = transform.worldToLocalMatrix * (transform.position - (Vector3)_position);
        if(Mathf.Abs(relativeLocalPosition.x) < boundsSize.x * 0.5f && Mathf.Abs(relativeLocalPosition.y) < boundsSize.y * 0.5f)
        {
            return true;
        }
        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, boundsSize);
    }
}