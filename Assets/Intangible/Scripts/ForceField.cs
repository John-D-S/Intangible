using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ForceField : MonoBehaviour
{
	private Collider2D thisCollider;
	[SerializeField, Tooltip("The magnitude of the force to apply to objects.")] private float force;
	
	private void Start()
	{
		//initialize the collider and set it to be a trigger
		thisCollider = GetComponent<Collider2D>();
		thisCollider.isTrigger = true;
	}

	private void OnTriggerStay2D(Collider2D _collider)
	{
		// apply a force to each rigidbody in the trigger
		_collider.attachedRigidbody.AddForce(transform.up * force);
	}
}
