using Unity.VisualScripting;
using UnityEngine;

// Attach to trash bins


// These do not use the mesh collider, rather I made smaller cube colliders
// That are at the bottom of each bin
public class TrashBin : MonoBehaviour
{
     public ShapeManager shapeManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
            shapeManager.cubeCount--;
            shapeManager.currentCube = null;

        }else if (other.CompareTag("Sphere"))
        {
            Destroy(other.gameObject);
            shapeManager.sphereCount--;
        }
        else
        {
            // We can keep this or get rid of it
            // Just maybe be careful sticking ur controller in it
            Destroy(other.gameObject);
        }
    }

}
