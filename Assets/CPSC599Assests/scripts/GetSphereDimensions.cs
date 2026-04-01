using UnityEngine;

// Attach to sphere prefab

// Works the exact same as GetCubeDimensions.cs except it uses radius and 
// Diamater. Read the other script for more info
public class GetSphereDimensions : MonoBehaviour
{
    private float initialScale;

    void Awake()
    {
        initialScale = transform.localScale.x;
    }

    

    // getters
    public float GetSphereDiameter()
    {
        return transform.localScale.x / initialScale;
    }

    public float GetSphereRadius()
    {
        return GetSphereDiameter() / 2f;
    }

    public float GetSphereVolume()
    {
        float r = GetSphereRadius();
        return (4f / 3f) * Mathf.PI * r * r * r;
    }

    public float GetSphereSurfaceArea()
    {
        float r = GetSphereRadius();
        return 4f * Mathf.PI * r * r;
    }
}
