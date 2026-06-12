/// 000314083 Jordan Marshall

using UnityEngine;

public class RandomSound : MonoBehaviour
{
    // Makes private variables editable in the inspector
    [SerializeField] private AudioSource audioSource;

    // Array to assign multiple sound effects
    [SerializeField] private AudioClip[] soundEffects;

    public void PlayRandomSound() // Call this to play a random sound
    {
        if (soundEffects.Length == 0 || audioSource == null)
            return;

        // Pick a random index between 0 and the length of the array
        int randomIndex = Random.Range(0, soundEffects.Length);

        // Play the chosen clip without interrupting currently playing sounds
        audioSource.PlayOneShot(soundEffects[randomIndex]);
    }
}