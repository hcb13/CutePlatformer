using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [Range(-1f, 1f)]
    [SerializeField]
    private float _speed = 0.1f;

    private float offset;
    private Material mat;

    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        offset += (Time.deltaTime * _speed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }

}
