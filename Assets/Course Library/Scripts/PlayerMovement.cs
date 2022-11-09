using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float turnSpeed;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(Vector3.forward * verticalInput * speed);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed);
    }
}
