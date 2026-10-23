using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ScrollDecalTexture : MonoBehaviour
{
    public Vector2 scrollAmount = new Vector2(1f,0);
    private DecalProjector decalProjector;
    void Start()
    {
        decalProjector = GetComponent<DecalProjector>();
    }

    void Update()
    {
        decalProjector.uvBias += scrollAmount * Time.deltaTime;
    }
}
