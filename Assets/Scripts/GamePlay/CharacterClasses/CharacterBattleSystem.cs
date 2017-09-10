using UnityEngine;

public class CharacterBattleSystem : MonoBehaviour
{
    public Vector2 CircleCastOrigin;
    public float Radius;

    public void Attack()
    {
        var enemyCollider = Physics2D.OverlapCircle(transform.position, Radius, 1 << LayerMask.NameToLayer("Enemy"));

        if (enemyCollider)
        {
            enemyCollider.gameObject.SetActive(false);
        }
    }
}
