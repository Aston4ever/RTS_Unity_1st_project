using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private float gravity = -25;
    [SerializeField] private float speed = 5;
    [SerializeField] private float jump = 10;

    private bool ground = true;
    private Rigidbody2D rgb;

    void Start()
    {
        Physics2D.gravity = new Vector2(0, gravity);
        rgb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        ground = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        ground = false;
    }

    void Update()
    {
        rgb.velocity = new Vector2(speed, rgb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && ground)
        {
            rgb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }
}