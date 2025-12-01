using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public int numberOfCoins = 20;
    public Vector2 spawnAreaSize = new Vector2(50, 50);
    public float spawnHeight = 50f;   // altura de onde o raycast começa
    public float extraHeight = 0.2f;  // moeda acima do chão
    public LayerMask groundMask;      // camada do chão

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        for (int i = 0; i < numberOfCoins; i++)
        {
            float x = Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f);
            float z = Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f);

            // Posição no ar
            Vector3 pos = new Vector3(
                transform.position.x + x,
                spawnHeight,
                transform.position.z + z
            );

            // 🔥 RAYCAST PARA BAIXO
            if (Physics.Raycast(pos, Vector3.down, out RaycastHit hit, 200f, groundMask))
            {
                Vector3 spawnPos = hit.point + Vector3.up * extraHeight;
                Instantiate(coinPrefab, spawnPos, Quaternion.identity);
            }
        }
    }
}

