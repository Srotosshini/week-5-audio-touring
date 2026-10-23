using UnityEngine;

public class RotateOnAxis : MonoBehaviour
{
    public Vector3 rotationAxis;

    void Update()
    {
        transform.Rotate(rotationAxis * Time.deltaTime);
    }
}
