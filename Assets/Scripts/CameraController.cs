using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;

    void LateUpdate()
    {
        transform.position = Target.position + Offset;
        transform.LookAt(Target);
    }
}
