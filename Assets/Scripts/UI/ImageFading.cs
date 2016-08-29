using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent(typeof(Image))]
public class ImageFading : MonoBehaviour {
    [Range(0, 1)]
    public float fadeFrom = 0;
    [Range(0, 1)]
    public float fadeTo = 1;
    public float Rate = 0.1f;

    private Image image;

	// Use this for initialization
	void Start () {


        if (GetComponent<Image>())
            image = GetComponent<Image>();
        else
            print("no Image");

        if (fadeFrom > fadeTo)
            Rate *= -1;

        UpdateAlpha(fadeFrom);
    }
	
	// Update is called once per frame
	void Update () {
        UpdateAlpha(Mathf.Clamp(image.color.a + Rate * Time.deltaTime, 0, 1));
    }

    private void UpdateAlpha(float value) {
        image.color = new Color(image.color.r, image.color.g, image.color.b, value);
    }
}
