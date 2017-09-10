using UnityEngine;

public class CharacterDeathChecker : MonoBehaviour
{
    private Vector3 _prevPosition;
    private float _timeToDeath;

    public float _timeToDeathDuration;
    public float _distanceThreshold;

    private void Start()
    {
        _prevPosition = transform.position;
    }

    private void Update()
    {
		if (_prevPosition == transform.position)
        {
            _timeToDeath += Time.deltaTime;

            if (_timeToDeath > _timeToDeathDuration)
            {
                GameSession.Instance.PlayerDied();
            }
        }
        else
        {
            _timeToDeath = 0.0f;
        }

        _prevPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GameSession.Instance.PlayerDied();
        }
    }
}
