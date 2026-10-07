using UnityEngine;

public class playerController : MonoBehaviour
{
    float speed = 3f;
    float jump = 6f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.y, jump);
        }

    }
}
