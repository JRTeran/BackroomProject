using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] clips;
    public float stepInterval = 0.5f;
    public float minVelocity = 0.1f;

    private AudioSource audioSource;
    private float timeSinceLastStep = 0f;
    private CharacterController characterController;
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.velocity.magnitude > minVelocity)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving && timeSinceLastStep > stepInterval)
        {
            PlayFootstepSound();
            timeSinceLastStep = 0f;
        }

        timeSinceLastStep += Time.deltaTime;
    }

    private void PlayFootstepSound()
    {
        int randomIndex = Random.Range(0, clips.Length);
        audioSource.PlayOneShot(clips[randomIndex]);
    }
}
