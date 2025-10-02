using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : MonoBehaviour
{
    private const float LevelMultiplier = 20;

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _audioGroup;

    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        slider.onValueChanged.AddListener(SetVolume);
    }

    private void OnDisable()
    {
        slider.onValueChanged.RemoveListener(SetVolume);
    }

    public void SetVolume(float level)
    {
        _audioMixer.SetFloat(_audioGroup, Mathf.Log10(level) * LevelMultiplier);
    }
}
