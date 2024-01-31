using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIEnhancementEffect : MonoBehaviour
{
    public float blinkDuration = 0.5f;

    //private Button button;
    private Image image;
    private Color originalColor;
    private bool isBlinking = true;

    void Start()
    {
        //button = GetComponent<Button>();
        image = GetComponent<Image>();

        // Store the original color
        originalColor = image.color;

        // Add the click event listener
       // button.onClick.AddListener(OnClick);

        // Start the initial blink
        StartCoroutine(Blink());
    }

    void OnClick()
    {
        // Your custom click functionality goes here
        Debug.Log("Button Clicked!");
    }

    IEnumerator Blink()
    {
        while (isBlinking)
        {
            // Make the image transparent
            image.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);

            // Wait for the blink duration
            yield return new WaitForSeconds(blinkDuration);

            // Make the image opaque
            image.color = originalColor;

            // Wait for the blink duration
            yield return new WaitForSeconds(blinkDuration);
        }
    }
}


