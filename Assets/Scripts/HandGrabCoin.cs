using UnityEngine;

public class HandGrabCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            CoinPickup coin = other.GetComponent<CoinPickup>();
            if (coin != null)
            {
                coin.Collect();
            }
        }
    }
}
