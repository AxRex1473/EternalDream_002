using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeView : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = AudioManager.Instance.GetVolume();
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderChanged);
    }

    private void OnVolumeSliderChanged(float volume)
    {
        VolumeController.Instance.UpdateVolume(volume);
    }
}
