using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject lookAtTarget;

    void Update()
    {
        if (lookAtTarget != null)
            transform.LookAt(lookAtTarget.transform);
    }
}
