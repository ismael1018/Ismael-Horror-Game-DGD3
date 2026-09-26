using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera playerCamera;
    public float range = 100f;
    public AudioClip gunSound;
    AudioSource AudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        AudioSource.PlayOneShot(gunSound);

        RaycastHit hit;

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {


            Enemyhealth enemy = hit.transform.GetComponent<Enemyhealth>();
            if (enemy != null)
            {
                enemy.TakeDamage();
            }
        }
    }
}