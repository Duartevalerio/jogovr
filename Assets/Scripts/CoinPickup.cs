using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public void Collect()
    {
        GameManager.Instance.AddCoin();
        Destroy(gameObject);
    }
}
