using System;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public static GameSession Instance;

    public Action OnPlayerDied;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayerDied()
    {
        if (OnPlayerDied != null)
        {
            OnPlayerDied.Invoke();
        }
        SceneManager.LoadScene("Game");
    }
}
