using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int amount = 1;
    void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.gameObject.tag != "Player") 
            return;

        _other.GetComponent<PlayerController>().AddGold(amount);

        Destroy(gameObject);
    }
}
