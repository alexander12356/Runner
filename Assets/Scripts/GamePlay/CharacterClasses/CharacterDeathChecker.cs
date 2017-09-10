using UnityEngine;

public class CharacterDeathChecker : MonoBehaviour
{
    private Vector3 _prevPosition;
    private float _timeToDeath;

    public float _timeToDeathDuration;
    public float _distanceThreshold;
    public float _killY = -5.0f;

    private void Start()
    {
        _prevPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.y < _killY)
        {
            GameSession.Instance.PlayerDied();
            gameObject.SetActive(false);
        }

        if (_prevPosition == transform.position)
        {
            _timeToDeath += Time.deltaTime;

            if (_timeToDeath > _timeToDeathDuration)
            {
                GameSession.Instance.PlayerDied();
                enabled = false;
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
