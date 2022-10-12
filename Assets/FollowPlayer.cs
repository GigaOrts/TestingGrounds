using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Quaternion thirdPersonRotationOffset;
    
    private Vector3 thirdPersonOffset;
    private Vector3 firstPersonOffset;
    private Vector3 viewOffset;

    private bool isViewSwitched = true;

    private void Start()
    {
        thirdPersonOffset = new Vector3(0f, 5.21000004f, -7.32999992f);
        firstPersonOffset = new Vector3(-0.67242837f, 2.10665917f, -0.0550551414f);

        SwitchPlayerView(isViewSwitched);
    }

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
            SwitchPlayerView(isViewSwitched);

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
        isViewSwitched = !toggle;

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
