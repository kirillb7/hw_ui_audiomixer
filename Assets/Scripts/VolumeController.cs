using UnityEngine;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{
    private const string MasterVolume = "MasterVolume";
    private const string MusicVolume = "MusicVolume";
    private const string EffectsVolume = "EffectsVolume";

    [SerializeField] private AudioMixer _audioMixer;

    public void SetMasterVolume(float level)
    {
        _audioMixer.SetFloat(MasterVolume, Mathf.Log10(level) * 20);
    }

    public void SetMusicVolume(float level)
    {
        _audioMixer.SetFloat(MusicVolume, Mathf.Log10(level) * 20);
    }

    public void SetEffectsVolume(float level)
    {
        _audioMixer.SetFloat(EffectsVolume, Mathf.Log10(level) * 20);
    }
}
