using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeToggle : MonoBehaviour
{
    private const float MutedLevel = -80;

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _audioGroup;

    private void Awake()
    {
        if (TryGetComponent(out Toggle toggle))
        {
            toggle.onValueChanged.AddListener(ToggleMute);
        }
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
