using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject GameOverPanel;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        GameSession.Instance.OnPlayerDied += ShowGameOverPanel;
    }

    private void ShowGameOverPanel()
    {
        GameOverPanel.SetActive(true);
    }

    private void Restart()
    {
        GameSession.Instance.Restart();
    }
}
