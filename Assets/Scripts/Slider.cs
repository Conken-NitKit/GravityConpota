using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{
    AudioSource m_AudioSource;

    public Slider m_Slider;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void SoundSliderOnValueChange(float newSliderValue)
    {
        m_AudioSource.volume = newSliderValue;
    }
}
