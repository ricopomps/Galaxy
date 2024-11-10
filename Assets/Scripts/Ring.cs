using UnityEngine;

public class Ring : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationBaseSpeed = 50f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationBaseSpeed * Time.deltaTime);
    }
}
