using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    private const float LevelMultiplier = 20;

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _audioGroup;

    private void Awake()
    {
        if (TryGetComponent(out Slider slider))
        {
            slider.onValueChanged.AddListener(SetVolume);
        }
    }

    public void SetVolume(float level)
    {
        _audioMixer.SetFloat(_audioGroup, Mathf.Log10(level) * LevelMultiplier);
    }
}
