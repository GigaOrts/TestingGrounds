using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        Destroy(this, 30);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
