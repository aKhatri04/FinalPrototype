using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // The player object to follow
    public Vector3 offset; // The offset distance from the player, adjustable in Inspector
    public float smoothSpeed = 0.125f; // Smoothing speed

    void Start()
    {
        // Optionally, set a default offset if not set in the Inspector
        if (offset == Vector3.zero)
        {
            offset = new Vector3(0, 5, -10); // Example offset above and behind the player
        }
    }

    void LateUpdate()
    {
        // Calculate the desired position based on the player's position and the offset
        Vector3 desiredPosition = player.transform.position + offset;

        // Update the camera's position smoothly
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}


