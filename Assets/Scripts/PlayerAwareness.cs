using UnityEngine;

public class PlayerAwareness : MonoBehaviour
{
    public bool AwareOfPlayer { get; private set; }

    public Vector2 DirectionToPlayer { get; private set; }

    [SerializeField]
    private float _PlayerAwarenessDistance;

    private Transform _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerController>().transform;
    }
 
    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayVector = _player.position - transform.position;
        DirectionToPlayer = enemyToPlayVector.normalized;

        if (enemyToPlayVector.magnitude <= _PlayerAwarenessDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}
