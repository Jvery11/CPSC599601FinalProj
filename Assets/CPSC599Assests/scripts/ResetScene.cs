using UnityEngine;
using UnityEngine.SceneManagement;

// Attach to the Red Button Object

// Simple script for restarting scene in case of errors
// Or to respawn environment items
public class ResetScene : MonoBehaviour
{
    // Reference: https://stackoverflow.com/questions/65851443/how-do-i-restart-the-scene-that-im-currently-in-through-script-in-unity-2d-so
    public void ResetCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
