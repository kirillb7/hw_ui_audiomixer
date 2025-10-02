using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : MonoBehaviour
{
    private const float LevelMultiplier = 20;
    private const float MutedLevel = -80;

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _audioGroup;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(SetVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(SetVolume);
    }

    public void SetVolume(float level)
    {
        if (level == 0)
        {
            _audioMixer.SetFloat(_audioGroup, MutedLevel);
        }
        else
        {
            _audioMixer.SetFloat(_audioGroup, Mathf.Log10(level) * LevelMultiplier);
        }
    }
}
