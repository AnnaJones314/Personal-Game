using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameInput gameInput;
    private Rigidbody rb;
    private float moveSpeed = 7f;


    void Awake()
    {
        gameInput.OnJumpPerformed += GameInput_OnJumpPerformed;
        rb = GetComponent<Rigidbody>();

    }

    private void GameInput_OnJumpPerformed(object sender, EventArgs e)
    {
        rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        //funky workaround to make sure capsule never falls over
        transform.rotation = new Quaternion(0,0,0,1);
    }

    private void HandleMovement()
    {
        float input = gameInput.GetMovement();
        Vector3 moveDir = new Vector3(input, 0, 0);
        float moveDistance = moveSpeed * Time.deltaTime;
        transform.position += moveDistance * moveDir;

        
    }
}
