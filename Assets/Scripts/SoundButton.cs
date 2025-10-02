using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(audioSource.Play);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(audioSource.Play);
    }
}
