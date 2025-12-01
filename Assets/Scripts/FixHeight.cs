using UnityEngine;

public class FixHeight : MonoBehaviour
{
    public CharacterController controller;
    public Transform cameraTransform;

    public float minHeight = 1.4f;
    public float maxHeight = 2.0f;
    public float skinOffset = 0.05f;

    void Update()
    {
        float headHeight = Mathf.Clamp(cameraTransform.localPosition.y, minHeight / 2f, maxHeight / 2f);

        controller.height = headHeight * 2f;

        controller.center = new Vector3(
            0,
            controller.height / 2f + skinOffset,
            0
        );
    }
}
