using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int coins = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddCoin()
    {
        coins++;
        Debug.Log("Moedas: " + coins);
    }
}
