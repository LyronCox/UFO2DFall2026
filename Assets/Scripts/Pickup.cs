using UnityEngine;

public class Pickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.gameObject.tag != "Player") 
            return;

        _other.GetComponent<PlayerController>().speed *= 2.0f;

        Destroy(gameObject);
    }
}
