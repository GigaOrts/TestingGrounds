using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float pushForce = 3f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        transform.Translate(new Vector3(x, 0f, z), Space.World);

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * pushForce);
        }
    }
}
