using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Vector3 offset = new Vector3(0f,2.72000003f,-4.23999977f);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
