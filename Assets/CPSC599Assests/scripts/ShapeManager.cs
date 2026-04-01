using UnityEngine;

// Attach to Shape Manager Object

// Script for keeping track of the # and types of shape
// within the environment
// This function will also handle spawning and despawning shapes
public class ShapeManager : MonoBehaviour
{
    public int sphereCount = 0;
    public int cubeCount = 0;

    // private readonly int maxShapeCount = 2;

    public GameObject spherePrefab;
    public GameObject cubePrefab;
    public Transform sphereSpawnPoint;
    public Transform cubeSpawnPoint;

    public GetCubeDimensions currentCube;
    public GetSphereDimensions currentSphere;


    // Resource for spawning prefabs:
    // https://medium.com/@Brian_David/mastering-game-object-management-in-unity-instantiation-and-destruction-2146db6f28f1
    public void SpawnShape(int shapeType)
    {
        // For steal thread I think we might make it so we can only spawn one of each shape
        // That way we can keep the dimensions on the board simple
        if (shapeType == 0 && cubeCount < 1)
        {
            // Keeps track of physical cube so we can read its dimensions
            GameObject spawnedCube = Instantiate(cubePrefab, cubeSpawnPoint.position, cubeSpawnPoint.rotation);
            cubeCount++;
            currentCube = spawnedCube.GetComponent<GetCubeDimensions>();
            return;
        }
        else if (shapeType == 1 && sphereCount < 1)
        {
            GameObject spawnedSphere = Instantiate(spherePrefab, sphereSpawnPoint.position, sphereSpawnPoint.rotation);
            sphereCount++;
            currentSphere = spawnedSphere.GetComponent<GetSphereDimensions>();
            return;

        }
    }












}
