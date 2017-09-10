using UnityEngine;

using EZ_Pooling;

public class PlatformGenerator : MonoBehaviour
{
    private Template _currentTemplate = null;

    [SerializeField]
    private float _pasteTemplateDistance = 0.0f;
    [SerializeField]
    private Transform[] _templateList = null;
    [SerializeField]
    private Transform _pasteTemplateTransform = null;

    public Transform _playerTransform;
    public float PasteTemplateRateTime;

    private void Start()
    {
        _currentTemplate = CreateTemplate(_pasteTemplateTransform);
    }

    private Template CreateTemplate(Transform _templateTransform)
    {
        var templateInstance = EZ_PoolManager.Spawn(GetRandomTemplate(), _templateTransform.position, Quaternion.identity).GetComponent<Template>();
        templateInstance.PlayerTransform = _playerTransform;
        return templateInstance;
    }

    private Transform GetRandomTemplate()
    {
        return _templateList[Random.Range(0, _templateList.Length)];
    }

    private void Update()
    {
        if (Vector3.Distance(_playerTransform.position, _currentTemplate.transform.position) < _pasteTemplateDistance)
        { 
            _currentTemplate = CreateTemplate(_currentTemplate.NextTemplateTransform);
        }
    }
}
