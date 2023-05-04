using UnityEngine;

public class HighLightableObject:MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _newColor;
   
    private Material _material; 
   
    private void Awake()
    {
        _material = _meshRenderer.material;
    }
   
    public void Highlight()
    {
        _material.color = _newColor;
    }
   
    public void Reset()
    {
        _material.color=Color.white;
    }
}