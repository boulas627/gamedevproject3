using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ImageFade : MonoBehaviour
{

    // the image you want to fade, assign in inspector
    public Image img;

    private void Start()
    {
        StartCoroutine(FadeImage(true));
    }
    
    public void Fadeout()
    {
        StartCoroutine(FadeImage(false));
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 3; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i/3);
                yield return null;
            }
            img.enabled = false;
        }
        // fade from transparent to opaque
        else
        {
            img.enabled = true;
            // loop over 1 second
            for (float i = 3; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i/3);
                yield return null;
            }
            SceneManager.LoadScene("EndScene");
        }
    }
}
