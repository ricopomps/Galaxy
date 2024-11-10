using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Public property to access the rotation speed
    public float RotationSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
    }
}
