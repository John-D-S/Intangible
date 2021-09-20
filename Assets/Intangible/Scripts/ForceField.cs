using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ForceField : MonoBehaviour
{
	private Collider2D thisCollider;
	[SerializeField] private float force;
	
	private void Start()
	{
		thisCollider = GetComponent<Collider2D>();
		thisCollider.isTrigger = true;
	}

	private void OnTriggerStay2D(Collider2D _collider)
	{
		_collider.attachedRigidbody.AddForce(transform.up * force);
	}
}
