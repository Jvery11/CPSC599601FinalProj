
using UnityEngine;

// Attach to Left Controller + Right Controller

// Helper scripting for notifying ShapeManager.cs to spawn a given shape
// Get attached to 
public class SginalShape : MonoBehaviour
{
    public ShapeManager shapeManager;

    // Need this so we dont spawn 100 at once and crash my app :(
    private bool canSpawn = true;
    public float spawnCooldown = 3.0f;


    private void OnTriggerEnter(Collider other)
    {
        if (!canSpawn)
        {
            return;
        }

        if (other.CompareTag("Cube"))
        {
            shapeManager.SpawnShape(0);
            Debug.Log("Spawning Cube");
            canSpawn = false;
            Invoke(nameof(ResetCooldown), spawnCooldown);
        }
        else if (other.CompareTag("Sphere"))
        {
            shapeManager.SpawnShape(1);
            Debug.Log("Spawning Sphere");
            canSpawn = false;
            Invoke(nameof(ResetCooldown), spawnCooldown);
        }


    }

    void ResetCooldown()
    {
        canSpawn = true;
    }
}
