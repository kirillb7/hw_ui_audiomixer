using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class VolumeToggle : MonoBehaviour
{
    private const float MutedLevel = -80;

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _audioGroup;

    private Toggle _toggle;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
    }

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ToggleMute);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ToggleMute);
    }

    public void ToggleMute(bool isMuted)
    {
        if (isMuted)
        {
            _audioMixer.SetFloat(_audioGroup, MutedLevel);
        }
        else
        {
            _audioMixer.SetFloat(_audioGroup, 0);
        }
    }
}
