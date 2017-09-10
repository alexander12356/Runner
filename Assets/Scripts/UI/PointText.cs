using UnityEngine;
using UnityEngine.UI;

public class PointText : MonoBehaviour
{
    private Text _text;

	private void Awake ()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        PointSystem.Instance.OnPointChanged += OnPointChanged;
    }

    private void OnPointChanged(int value)
    {
        _text.text = "Points: " + value;
    }
}
