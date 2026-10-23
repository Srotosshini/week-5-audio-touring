using UnityEngine;

public class DelayedVisibility : MonoBehaviour
{
    public GameObject target;
    public float delay = 1f;
    public bool showAfterDelay = true;

    void Start()
    {
        target.SetActive(!showAfterDelay);
        Invoke("Toggle", delay);
    }

    void Toggle()
    {
        target.SetActive(showAfterDelay);
    }
}