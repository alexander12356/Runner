using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D _rigidBody2d;

    [SerializeField]
    private Transform _raycastCircleTransform = null;

    public float Speed;
    public Vector2 JumpForce;

    private void Awake()
    {
        _rigidBody2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidBody2d.velocity = new Vector2(Speed, _rigidBody2d.velocity.y);
    }

    public void Jump()
    {
        var groundObject = Physics2D.OverlapCircle(_raycastCircleTransform.position, 1.0f, 1 << LayerMask.NameToLayer("Ground"));
        if (groundObject)
        {
            _rigidBody2d.AddForce(JumpForce);
        }
    }
}
