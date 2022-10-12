using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        Quaternion quat = transform.rotation;

        Vector3 newangles = new Vector3(
            transform.rotation.eulerAngles.x, 
            transform.rotation.eulerAngles.y,
            player.transform.rotation.eulerAngles.z);

        quat.eulerAngles = newangles;

        transform.rotation = quat;
    }
}
