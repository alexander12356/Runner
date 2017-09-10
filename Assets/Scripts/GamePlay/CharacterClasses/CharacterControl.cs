using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    private void Awake()
    {
        SimpleGesture.On4AxisSwipeUp(GetComponent<CharacterMovement>().Jump);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<CharacterMovement>().Jump();
        }
    }
}
