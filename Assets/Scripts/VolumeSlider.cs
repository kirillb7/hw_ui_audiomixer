using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _audioGroup;

    public void SetVolume(float level)
    {
        _audioMixer.SetFloat(_audioGroup, Mathf.Log10(level) * 20);
    }
}
