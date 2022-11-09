using UnityEngine;

public class PlayerMovement
{
    [SerializeField] protected float speed;
    [SerializeField] protected float turnSpeed;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * Time.deltaTime;


    }
}
