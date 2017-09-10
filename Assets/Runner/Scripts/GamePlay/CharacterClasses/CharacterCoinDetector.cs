using UnityEngine;

public class CharacterCoinDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            var coin = collision.GetComponent<Coin>();
            PointSystem.Instance.AddPoint(coin.Price);
            coin.gameObject.SetActive(false);
        }
    }
}
