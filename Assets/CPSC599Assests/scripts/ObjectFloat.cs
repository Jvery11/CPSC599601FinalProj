using UnityEngine;

// Attach to cube and sphere in scene. Do not have on prefab

// Script for making the simple shapes float up and down
// Reference: https://discussions.unity.com/t/how-to-make-an-object-move-up-and-down-on-a-loop/612962/4
public class ObjectFloat : MonoBehaviour
{
    public float speed = 5f;
    public float height = 0.2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height;
        transform.position = startPos + new Vector3(0, newY, 0);
    }
}
