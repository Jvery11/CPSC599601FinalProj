using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Attach to Shape Manager Object

// Script for reading shape dimensions and applying them to the chalk board
public class ReadShapeDimensions : MonoBehaviour
{
    public TMP_Text cubeText;
    public TMP_Text sphereText;

    public ShapeManager shapeManager;


    // Update is called once per frame
    void Update()
    {
        // Only read dims if object is spawned
        if (shapeManager.cubeCount == 1 && shapeManager.currentCube != null)
        {
            float cubeWidth = shapeManager.currentCube.GetCubeWidth();
            float cubeHeight = shapeManager.currentCube.GetCubeHeight();
            float cubeVolume = shapeManager.currentCube.GetCubeVolume();
            float cubeSurfaceArea = shapeManager.currentCube.GetCubeSurfaceArea();

            // Output formatting
            // Currently rounding to 2 decimal points
            cubeText.text =
            $"Cube:\n" +
            $"  Width: {cubeWidth:F2}      Volume: {cubeVolume:F2}\n" +
            $"  Height: {cubeHeight:F2}      Surface Area: {cubeSurfaceArea:F2}";
        }
        else
        {
            cubeText.text =
            $"Cube:\n" +
            $"  Width: xx     Volume: xx\n" +
            $"  Height: xx    Surface Area: xx";
            
        }


        if (shapeManager.sphereCount == 1 && shapeManager.currentSphere != null)
        {
            float sphereRadius = shapeManager.currentSphere.GetSphereRadius();
            float sphereDiameter = shapeManager.currentSphere.GetSphereDiameter();
            float sphereVolume = shapeManager.currentSphere.GetSphereVolume();
            float sphereSurfaceArea = shapeManager.currentSphere.GetSphereSurfaceArea();
          

            // Output formatting
            // Currently rounding to 2 decimal points
            sphereText.text =
            $"Sphere:\n" +
            $"  Radius: {sphereRadius:F2}      Volume: {sphereVolume:F2}\n" +
            $"  Diameter: {sphereDiameter:F2}    Surface Area: {sphereSurfaceArea:F2}";
        }
        else
        {
            sphereText.text =
            $"Sphere:\n" +
            $"  Radius: xx      Volume: xx\n" +
            $"  Diameter: xx    Surface Area: xx";
            
        }



    }
}
