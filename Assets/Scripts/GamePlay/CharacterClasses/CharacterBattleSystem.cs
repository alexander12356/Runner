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
#if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            Attack();
        }
#endif
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
