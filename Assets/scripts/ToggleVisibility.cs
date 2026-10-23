using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject target;
    public float interval = 1f;

    private float timer;

    void Start()
    {
        target.SetActive(false);
        timer = interval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            target.SetActive(!target.activeSelf);
            timer = interval;
        }
    }
}