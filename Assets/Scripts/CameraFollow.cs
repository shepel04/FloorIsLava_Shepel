using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Do not set an object");
            return;
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
