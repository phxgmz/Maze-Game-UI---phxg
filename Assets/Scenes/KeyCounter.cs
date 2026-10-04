using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("UI Reference")]
    public TextMeshProUGUI scoreText;

    private int keysCollected = 0;

    void Start()
    {
        UpdateScoreUI();
    }

    // Changed from OnTriggerEnter2D to OnTriggerEnter for 3D physics
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object we hit has the "Key" tag
        if (other.CompareTag("Key"))
        {
            keysCollected++;
            UpdateScoreUI();
            Destroy(other.gameObject);
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Keys: " + keysCollected;
        }
    }
}
