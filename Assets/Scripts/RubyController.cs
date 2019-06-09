using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float speed = 3.0f;

        Vector2 position = rigidbody2d.position;
        position.x = position.x + (speed * horizontal * Time.deltaTime);
        position.y = position.y + (speed * vertical * Time.deltaTime);
        rigidbody2d.position = position;
    }
}
