using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent(typeof(Text))]
public class TextFade : MonoBehaviour {
    [Range(0, 1)]
    public float fadeFrom = 0;
    [Range(0, 1)]
    public float fadeTo = 1;
    public float Rate = 0.1f;

    private Text text;

	// Use this for initialization
	void Start () {


        if (GetComponent<Text>())
            text = GetComponent<Text>();
        else
            print("no Text");

        if (fadeFrom > fadeTo)
            Rate *= -1;

        UpdateAlpha(fadeFrom);
    }
	
	// Update is called once per frame
	void Update () {
        UpdateAlpha(Mathf.Clamp(text.color.a + Rate * Time.deltaTime, 0, 1));
    }

    private void UpdateAlpha(float value) {
        text.color = new Color(text.color.r, text.color.g, text.color.b, value);
    }
}
