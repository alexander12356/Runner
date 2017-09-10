using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    private void Awake()
    {
        //SimpleGesture.On4AxisSwipeUp(GetComponent<CharacterMovement>().Jump);
    }

    private void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetMouseButton(0))
        {
            Attack();
        }
#endif
    }

    public void Jump()
    {
        if (GetComponent<CharacterLive>().isLive)
        {
            GetComponent<CharacterMovement>().Jump();
        }
    }

    public void Attack()
    { 
        if (GetComponent<CharacterLive>().isLive)
        {
            GetComponent<CharacterBattleSystem>().Attack();
        }
    }
}
