using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        GameObject playership;
        GameObject bullet;
        GameObject asteroid;

        private float playerSpeed = 5f;

    }

    // Update is called once per frame
    void Update()
    {        
        getKey("w")
           y vector playership.translate(5f) * deltaTime;

        getKey("a")
           x vector playership.translate(-5f) * deltaTime;

        getKey("s")
            y vector == playership.translate(-5f) * deltaTime;

        getKey("d")
            x vector == playership.translate(5f) * deltaTime;

        OnTriggerEnter
            de
    }

      {
    private CharacterController controller;
private Vector3 playerVelocity;
private float playerSpeed = 2.0f;

private void Start()
{
    controller = gameObject.AddComponent<CharacterController>();
}

void Update()
{
    groundedPlayer = controller.isGrounded;
    if (groundedPlayer && playerVelocity.y < 0)
    {
        playerVelocity.y = 0f;
    }

    Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    controller.Move(move * Time.deltaTime * playerSpeed);

    if (move != Vector3.zero)
    {
        gameObject.transform.forward = move;
    }

    controller.Move(playerVelocity * Time.deltaTime);
}