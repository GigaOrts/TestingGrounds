using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        transform.position = player.position + offset;

        Quaternion targetQuaternion = transform.rotation;

        targetQuaternion.eulerAngles = new Vector3(
            transform.rotation.eulerAngles.x,
            transform.rotation.eulerAngles.y,
            player.rotation.eulerAngles.z);

        transform.rotation = targetQuaternion;
    }
}
