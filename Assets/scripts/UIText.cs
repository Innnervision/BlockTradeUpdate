using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class UIText : MonoBehaviour
{
    public float blinkDuration = 0.5f;

    private Text text;
    private Color originalColor;

    void Start()
    {
        text = GetComponent<Text>();

        // Store the original color
        originalColor = text.color;

        // Start the blink
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (true)
        {
            // Make the text transparent
            text.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);

            // Wait for the blink duration
            yield return new WaitForSeconds(blinkDuration);

            // Make the text opaque
            text.color = originalColor;

            // Wait for the blink duration
            yield return new WaitForSeconds(blinkDuration);
        }
    }
}
