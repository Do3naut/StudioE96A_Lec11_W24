using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + slider.value;

        mixer.SetFloat("BGMVolume", slider.value - 80f);
    }
}
