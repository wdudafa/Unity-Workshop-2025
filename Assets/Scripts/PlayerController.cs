using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody2D rb2d;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void HandleMove(InputAction.CallbackContext callbackContext)
    {
        Vector2 input = callbackContext.ReadValue<Vector2>();
        rb2d.velocity = input * moveSpeed;
    }


}
