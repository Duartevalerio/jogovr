using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotação no eixo X (horizontal)
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
