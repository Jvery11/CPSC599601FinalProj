using UnityEngine;
// Attach to cube prefab 

// Helper script to return cube dimensions so it can be written to the canvas
// This script also does some normalization so the inital cube height, width, depth are all 1
// Used a bit of AI for figuring out the best way to read the shape params and do the normalization
// Will add as reference in README
public class GetCubeDimensions : MonoBehaviour
{
    private Vector3 initialScale;

    void Awake()
    {
        initialScale = transform.localScale;
    }


    // getters
    public float GetCubeWidth()
    {
        return transform.localScale.x / initialScale.x;
    }

    public float GetCubeHeight()
    {
        return transform.localScale.y / initialScale.y;
    }

    public float GetCubeDepth()
    {
        return transform.localScale.z / initialScale.z;
    }

    public float GetCubeVolume()
    {
        float width = GetCubeWidth();
        float height = GetCubeHeight();
        float depth = GetCubeDepth();
        return width * height * depth;
    }

    // Slightly more complicated so it should also work
    // if we use none uniform scaling
    public float GetCubeSurfaceArea()
    {
        float width = GetCubeWidth();
        float height = GetCubeHeight();
        float depth = GetCubeDepth();
        return 2f * ((width * height) + (width * depth) + (height * depth));
    }
}



