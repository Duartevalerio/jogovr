using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabCoinCollect : MonoBehaviour
{
    public AudioClip pickupSound;

    private void OnEnable()
    {
        // Quando a moeda é "agarrada"
        GetComponent<XRBaseInteractable>().selectEntered.AddListener(OnGrab);
    }

    private void OnDisable()
    {
        GetComponent<XRBaseInteractable>().selectEntered.RemoveListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        // Adiciona moeda ao GameManager
        GameManager.Instance.AddCoin();

        // Som (opcional)
        if (pickupSound)
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);

        // Destrói moeda
        Destroy(gameObject);
    }
}
