using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform _targetTransform;

    public float Speed;

    private void Update()
    {
        float interpolation = Speed * Time.deltaTime;

        Vector3 position = transform.position;
        position.y = Mathf.Lerp(transform.position.y, _targetTransform.position.y, interpolation);
        position.x = Mathf.Lerp(transform.position.x, _targetTransform.position.x, interpolation);

        transform.position = position;
    }
}
