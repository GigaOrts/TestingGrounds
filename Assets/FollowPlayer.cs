using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 thirdPersonOffset;
    [SerializeField] private Quaternion thirdPersonRotationOffset;
    [SerializeField] private Vector3 firstPersonOffset;

    private bool isSwitchedView = true;
    private Vector3 viewOffset;

    private void Start()
    {
        SwitchPlayerView(isSwitchedView);
    }

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
            SwitchPlayerView(isSwitchedView);

        transform.position = player.position + viewOffset;

        Quaternion targetQuaternion = transform.rotation;

        targetQuaternion.eulerAngles = new Vector3(
            transform.rotation.eulerAngles.x,
            transform.rotation.eulerAngles.y,
            player.rotation.eulerAngles.z);

        transform.rotation = targetQuaternion;
    }

    private void SwitchPlayerView(bool toggle)
    {
        isSwitchedView = !toggle;

        if (toggle)
        {
            viewOffset = thirdPersonOffset;
            transform.rotation = thirdPersonRotationOffset;
        }
        else
        {
            viewOffset = firstPersonOffset;
            transform.rotation = Quaternion.identity;
        }
    }
}
