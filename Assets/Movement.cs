using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float turnSpeed = 30f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        verticalInput = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        transform.Translate(verticalInput * speed * Vector3.forward);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed);
    }
}
