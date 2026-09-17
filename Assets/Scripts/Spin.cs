using UnityEngine;

public class Spin : MonoBehaviour
{
   public float speed = 180.0f;
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, speed) * Time.deltaTime);
    }
}
