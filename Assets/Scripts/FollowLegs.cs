using UnityEngine;

public class FollowLegs : MonoBehaviour
{
    public Transform xrRig;
    public Transform cameraTransform;

    public float footOffset = 0.0f;
    public float followSpeed = 10f;

    void Start()
    {
        // Coloca as pernas na posição correta logo ao iniciar
        Vector3 startPos = xrRig.position;
        startPos.y = xrRig.position.y - cameraTransform.localPosition.y;
        transform.position = startPos;
    }

    void LateUpdate()
    {
        Vector3 targetPos = xrRig.position;

        // calcula a altura real dos pés em relação à camera (dinâmico)
        float cameraLocalY = cameraTransform.localPosition.y;
        targetPos.y -= cameraLocalY;
        targetPos.y += footOffset;

        // movimento suave
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * followSpeed);
    }
}
