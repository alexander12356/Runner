using UnityEngine;

public class CharacterDeathChecker : MonoBehaviour
{
    private Vector3 _prevPosition;
    private float _timeToDeath;
    private CharacterLive _characterLive;

    public float _timeToDeathDuration;
    public float _distanceThreshold;
    public float _killY = -5.0f;

    private void Awake()
    {
        _characterLive = GetComponent<CharacterLive>();
    }

    private void Start()
    {
        _prevPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.y < _killY)
        {
            _characterLive.Death();
        }

        if (_prevPosition == transform.position)
        {
            _timeToDeath += Time.deltaTime;

            if (_timeToDeath > _timeToDeathDuration)
            {
                _characterLive.Death();
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
            _characterLive.Death();
        }
    }
}
