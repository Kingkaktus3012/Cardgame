using UnityEngine;
using UnityEngine.UI;

public class ObjectPlacer : MonoBehaviour
{
    public GameObject objectToPlace; // The 2D object prefab to be placed
    public float posX = 0f; // Default X coordinate
    public float posY = 0f; // Default Y coordinate
    public Transform canvasTransform; // Reference to the Canvas transform

    void Start()
    {
        // You can set default coordinates here if needed
        // posX = 0f;
        // posY = 0f;
    }

    public void PlaceObject()
    {
        // Create a new object instance at the specified coordinates with random rotation
        Vector2 position = new Vector2(posX, posY);
        Quaternion randomRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)); // Random rotation around Z-axis
        GameObject newObject = Instantiate(objectToPlace, position, randomRotation);

        // Set the Canvas as the parent of the instantiated object
        if (canvasTransform != null && newObject != null)
        {
            newObject.transform.SetParent(canvasTransform, false);
        }
    }
}

