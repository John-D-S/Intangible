using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField, Tooltip("The GameObject to follow.")] GameObject player;
    [SerializeField, Tooltip("The time it takes to lerp the camera's position.")] float posLerpTime = 0.5f;
    [SerializeField, Tooltip("The time it takes to lerp the camera's scale based on speed.")] float scaleLerpTime = 0.1f;
    [SerializeField, Tooltip("The base scale when the camera is not moving.")] float baseScale = 8;
    [SerializeField, Tooltip("How much the scale changes based on speed")] float scaleMultiplier = 5;

    private Camera cameraComponent;
    //The player's position one fixedUpdate ago, used to find speed
    private Vector2 lastFramePlayerPosition;
    Vector3 targetPosition = Vector3.zero;
    float targetCameraSize = 0;

    void Start()
    {
        //initialise the lastFrame's playerPosition;
        lastFramePlayerPosition = player.transform.position;
        cameraComponent = gameObject.GetComponent<Camera>();
    }

    //i copied this script from one of my first projects and i only realised that the camera movement is in fixed update after finishing.
    //it really isn't worth changing the settings in unity for moving this code to Update.
    void FixedUpdate()
    {
        //set the target camera size based on the speed of the player
        targetCameraSize = baseScale + Mathf.Abs((((Vector2)player.transform.position - lastFramePlayerPosition) * scaleMultiplier).magnitude);
        //set the camera's target position based on the player's position
        targetPosition = player.transform.position + Vector3.back;

        //set the lerp the size and position to their respective targets 
        cameraComponent.orthographicSize = Mathf.Lerp(cameraComponent.orthographicSize, targetCameraSize, scaleLerpTime);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition, posLerpTime);

        lastFramePlayerPosition = player.transform.position;
    }
}
