using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float movementSpeed;
    [SerializeField] float xMove;
    [SerializeField] float yMove;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        yMove = Input.GetAxis("Vertical");
        xMove = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(xMove, yMove);

        //Switched back to rb.addforce as rb.moveposition is meant for kinematinc rb's

        rb.AddForce(movement * movementSpeed * Time.deltaTime);
    }
}
