using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip SpikeImpact;
    public AudioClip HowieScream;
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;

    public void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
            audioSource.PlayOneShot(SpikeImpact);
        }
        else if (col.tag == "Pin")
        {
            Debug.Log("rounds: " + KeepData.RoundsPlayed.ToString());
            if (KeepData.HighScore < KeepData.PlayerScore)
            {
                KeepData.HighScore = KeepData.PlayerScore;
            }
            
            FindObjectOfType<GameManager>().EndGame();
           audioSource.PlayOneShot(HowieScream);
        }
    }
}
