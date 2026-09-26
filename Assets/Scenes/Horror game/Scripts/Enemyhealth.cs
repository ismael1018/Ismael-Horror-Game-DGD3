using UnityEngine;
using System.Collections;

public class Enemyhealth : MonoBehaviour
{
    public int health;
    public AudioClip deathSound;
    AudioSource audioSource;
    Renderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {
        health--;
        StartCoroutine(FlashRed());

        if (health <= 0)
        {
            Gamemanager.instance.EnemyKilled();
            audioSource.PlayOneShot(deathSound);
            Destroy(gameObject, deathSound.length);
        }
    }

    IEnumerator FlashRed()
    {
        rend.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        rend.material.color = Color.white;
    }
}
