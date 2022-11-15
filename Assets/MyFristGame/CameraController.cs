
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float horizontalDistance;
    [SerializeField] float height;

    // Update is called once per frame
    void LateUpdate()
    {
        // Rotation
        Vector3 direction = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);

        // Movement

        Vector3 offsetHorizontal = -target.forward * horizontalDistance;

        Vector3 offsetVertical = new Vector3(0, height, 0);

        Vector3 cameraPos = target.position + offsetHorizontal + offsetVertical;

        transform.position = cameraPos;
    }
}
