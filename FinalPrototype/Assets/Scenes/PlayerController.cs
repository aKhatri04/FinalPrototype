
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour {

    public Vector2 moveValue;
    public float speed = 5f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>();
        Debug.Log("Move Value: " + moveValue);
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveValue.x, 0.0f, moveValue.y);
        Debug.Log("Movement Vector: " + movement);
        rb.AddForce(movement * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}

