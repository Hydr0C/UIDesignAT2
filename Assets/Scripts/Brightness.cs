using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public Image brightnessOverlay;
    [SerializeField] Slider brightnessSlider;

    [Range(0f, 100f)]
    public float brightnessIntensity;

    private float brightnessNormalized;

    // Start is called before the first frame update
    void Start()
    {
        brightnessNormalized = brightnessIntensity / 100;

        float brightnessFlip = 1 - brightnessNormalized;

        brightnessOverlay.color = new Color(brightnessOverlay.color.r, brightnessOverlay.color.g, brightnessOverlay.color.b, brightnessFlip);
    }

    // Update is called once per frame
    void Update()
    {
        brightnessIntensity = brightnessSlider.value;
        brightnessNormalized = brightnessIntensity / 100;

        float brightnessFlip = 1 - brightnessNormalized;

        brightnessOverlay.color = new Color(brightnessOverlay.color.r, brightnessOverlay.color.g, brightnessOverlay.color.b, brightnessFlip);
    }
}
