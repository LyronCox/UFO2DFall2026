using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8.0f;
    private Rigidbody2D rb2d;
    private Vector3 startingScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        startingScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if (direction != Vector2.zero)
            direction.Normalize();
        // else
        {
         // rb2d.linearVelocity *= 0.5f;
        }

        rb2d.AddForce(direction * speed);

        if (transform.localScale.x > startingScale.x)
                transform.localScale -= new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);

        if (transform.localScale.x < startingScale.x)
                transform.localScale = startingScale;
    }

    void OnCollisionEnter2D(Collision2D _collision){
        transform.localScale = startingScale * 1.2f;
    }
}
