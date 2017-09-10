using UnityEngine;

public class CharacterBattleSystem : MonoBehaviour
{
    public Vector2 CircleCastOrigin;
    public float Radius;

    private void Awake()
    {
        SimpleGesture.OnTap(Attack);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Attack();
        }
	}

    private void Attack()
    {
        var enemyCollider = Physics2D.OverlapCircle(transform.position, Radius, 1 << LayerMask.NameToLayer("Enemy"));

        if (enemyCollider)
        {
            enemyCollider.gameObject.SetActive(false);
        }
    }
}
