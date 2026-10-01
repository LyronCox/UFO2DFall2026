using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotationSpeed;

    private Rigidbody2D _rigidbody;
    private PlayerAwareness _PlayerAwareness;
    private Vector2 _targetDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _PlayerAwareness = GetComponent<PlayerAwareness>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        if (_PlayerAwareness.AwareOfPlayer)
        {
            _targetDirection = _PlayerAwareness.DirectionToPlayer;
        }
        else
        {
            _targetDirection = Vector2.zero;
        }
    }


    private void RotateTowardsTarget()
    {
        if (_targetDirection == Vector2.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);

        _rigidbody.SetRotation(rotation);   
    }

    private void SetVelocity()
    {
        if (_targetDirection == Vector2.zero)
        {
            GetComponent<Rigidbody>().linearVelocity = Vector2.zero;
        }
        else
        {
            _rigidbody.linearVelocity = transform.up * _speed;
        }
    }
}
