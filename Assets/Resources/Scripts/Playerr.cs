using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerr : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 10f;
    public JoysticController joysticController;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (joysticController.JoystickVector.y != 0)
        {
            rb.velocity = new Vector2(joysticController.JoystickVector.x * moveSpeed, joysticController.JoystickVector.y * moveSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
