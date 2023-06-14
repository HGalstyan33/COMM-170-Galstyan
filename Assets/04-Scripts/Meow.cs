using UnityEngine;
using UnityEngine.InputSystem;

public class Meow : MonoBehaviour
{
    [SerializeField] private InputActionReference meowButton;
    private AudioSource meowAudio;

    void Start()
    {
        meowAudio = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (meowButton.action.triggered)
        {
            meowAudio.Play();
        }
    }
}
