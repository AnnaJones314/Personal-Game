using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputHandler playerInputHandler;
    public EventHandler OnJumpPerformed;


    private void Awake()
    {
        playerInputHandler = new PlayerInputHandler();
        playerInputHandler.Player.Enable();
        playerInputHandler.Player.Jump.performed += Jump_performed;
    }

    private void Jump_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnJumpPerformed?.Invoke(this, EventArgs.Empty);
    }


    public float GetMovement()
    {
        float move = playerInputHandler.Player.Move.ReadValue<float>();
        return move;
    }
}
