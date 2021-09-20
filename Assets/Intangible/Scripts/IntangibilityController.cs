using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntangibilityController : MonoBehaviour
{
    public static GameObject player;
    private Collider2D thisCollider;
    private SpriteRenderer spriteRenderer;

    private Color spriteStartColor;
    private Color IntangibleColor => new Color(spriteStartColor.r, spriteStartColor.g, spriteStartColor.b, spriteStartColor.a * 0.25f);
    
    private void Start()
    {
        thisCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteStartColor = spriteRenderer.color;
        player = gameObject;
    }

    private void Update()
    {
        thisCollider.enabled = !Input.GetMouseButton(0);
        spriteRenderer.color = Input.GetMouseButton(0) ? IntangibleColor : spriteStartColor;
    }
}
