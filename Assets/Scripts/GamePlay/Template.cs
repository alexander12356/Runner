using UnityEngine;

using EZ_Pooling;

public class Template : MonoBehaviour
{
    private Transform _playerTransform;

    [SerializeField]
    private Transform _nextTemplateTransform = null;
    [SerializeField]
    private float _deathDistance = 0.0f;
    [SerializeField]
    private Coin[] _coinList;

    public Transform NextTemplateTransform
    {
        get { return _nextTemplateTransform; }
    }

    public Transform PlayerTransform
    {
        get { return _playerTransform; }
        set { _playerTransform = value; }
    }

    private void Update()
    {
        if (_playerTransform.position.x > transform.position.x && Vector3.Distance(_playerTransform.position, transform.position) > _deathDistance)
        {
            Despawn();
        }
    }

    private void OnSpawned()
    {
        for (int i = 0; i < _coinList.Length; i++)
        {
            _coinList[i].gameObject.SetActive(true);
        }
    }

    private void OnDespawned()
    {

    }

    private void Despawn()
    {
        EZ_PoolManager.Despawn(transform);
    }
}
