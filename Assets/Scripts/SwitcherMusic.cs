using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SwitcherMusic : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup AudioMixer;
    [SerializeField] private Slider _masterSlider;
    [SerializeField] private Slider _backgroundSlider;
    [SerializeField] private Slider _buttonSlider;

    private const string MasterParameter = "MasterVolume";
    private const string ButtonParameter = "ButtonVolume";
    private const string MusicParameter = "MusicVolume";

    public void ToggleMusic(bool isEnable)
    {
        if (isEnable) AudioMixer.audioMixer.SetFloat(MasterParameter, 0);
        else AudioMixer.audioMixer.SetFloat(MasterParameter, -60);
    }

    public void SetAllVolume()
    {
        float volume = _masterSlider.value;
        AudioMixer.audioMixer.SetFloat(MasterParameter, Mathf.Lerp(-60, 0, volume));
    }

    public void SetButtonVolume()
    {
        float volume = _buttonSlider.value;
        AudioMixer.audioMixer.SetFloat(ButtonParameter, Mathf.Lerp(-40, 0, volume));
    }

    public void SetBackgroundVolume()
    {
        float volume = _backgroundSlider.value;
        AudioMixer.audioMixer.SetFloat(MusicParameter, Mathf.Lerp(-40, 20, volume));
    }
}
