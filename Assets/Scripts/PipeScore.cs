using UnityEngine;

public class PipeScore : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindAnyObjectByType<Score>().UpdateScore();
            audioSource.Play();
        }
    }
}
