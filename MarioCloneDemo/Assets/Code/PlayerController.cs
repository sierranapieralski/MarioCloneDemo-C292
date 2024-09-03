using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float runSpeed;    // SerializeField makes private fields seralized
    [SerializeField] private float jumpSpeed;


    [SerializeField] private Vector2 direction;

    [SerializeField] private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        // checks if something is run every frame (if you press anything)
        Move();
        Jump();
    }

    private void Move() 
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveInput * runSpeed * Time.deltaTime);
    }

    private void Jump() 
    {
        if (Input.GetButtonDown("Jump")) 
        { 
            rb2d.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        }
    }
}
