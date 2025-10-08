using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DangerScript : MonoBehaviour
{
    public TMP_Text gameOverText;
    public float RotationSpeed1 = 0f;
    public float RotationSpeed2 = 100f;
    public float RotationSpeed3 = 0f;

    private void Start()
    {
        // Hide game over text at start
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
            // Or: gameOverText.text = "";
        }
    }

    void Update()
    {
        Debug.Log("Rotating danger object...");

        transform.Rotate(RotationSpeed1 * Time.deltaTime, RotationSpeed2 * Time.deltaTime, RotationSpeed3 * Time.deltaTime, Space.World);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))  // Assuming player tag is "Player"
        {
            // Kill player (disable)
            other.gameObject.SetActive(false);

            // Show Game Over text
            if (gameOverText != null)
            {
                gameOverText.gameObject.SetActive(true);
                gameOverText.text = "Game Over";
            }
            else
            {
                Debug.LogWarning("gameOverText not assigned in DangerScript!");
            }
        }
    }
}
