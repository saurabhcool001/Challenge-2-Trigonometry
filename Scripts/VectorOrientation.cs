using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VectorOrientation : MonoBehaviour
{
    // Input vector components (x, y)
    // Default x value
    public float vectorX = 1f;
    // Default y value
    public float vectorY = 1f; 

    // Reference to the UI Text element
    public TMP_Text angleDisplayText;

    void Update()
    {
        // Calculate the angle in radians
        float angleRadians = Mathf.Atan2(vectorY, vectorX);

        // Convert radians to degrees
        float angleDegrees = angleRadians * Mathf.Rad2Deg;

        // Display the angle in the UI Text
        angleDisplayText.text = $"Vector ({vectorX}, {vectorY})\nAngle: {angleDegrees:F2}°";

        // Draw the vector in the Scene view
        Debug.DrawLine(Vector3.zero, new Vector3(vectorX, vectorY, 0), Color.red);
    }

    // Visualize the vector in the Game view when selected
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, new Vector3(vectorX, vectorY, 0));
    }
}