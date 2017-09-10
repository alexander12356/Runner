using UnityEngine;
using UnityEngine.SceneManagement;

public class KillY : MonoBehaviour
{
    [SerializeField]
    private float _killY = -5.0f;

	private void Update ()
    {
		if (transform.position.y < _killY)
        {
            SceneManager.LoadScene("Game");
        }
	}
}
