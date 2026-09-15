using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        rb2d.AddForce(direction * 10.0f);
    }
}
