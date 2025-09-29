using UnityEngine;
using UnityEngine.Audio;

public class VolumeToggle : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _audioGroup;

    public void ToggleMute(bool isMuted)
    {
        float level = 1;

        if (isMuted)
        {
            level = 0.0001f;
        }

        _audioMixer.SetFloat(_audioGroup, Mathf.Log10(level) * 20);
    }
}
