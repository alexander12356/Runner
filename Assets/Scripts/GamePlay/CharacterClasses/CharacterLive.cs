using UnityEngine;

public class CharacterLive : MonoBehaviour
{
    private bool _live = true;

    public bool isLive
    {
        get { return _live; }
    }

    public void Death()
    {
        gameObject.SetActive(false);
        _live = false;
        GameSession.Instance.PlayerDied();
    }
}
