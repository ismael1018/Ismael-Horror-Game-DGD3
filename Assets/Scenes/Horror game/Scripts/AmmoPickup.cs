using UnityEngine;

public class AmmoPickup : MonoBehaviour, IInteractable
{
    public int amount = 5;
    public AudioClip pickupSound;

    public void Interact()
    {
        Shooting shooting = FindFirstObjectByType<Shooting>();
        if (shooting != null)
            shooting.AddAmmo(amount);

        if (pickupSound != null)
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);

        Destroy(gameObject);
    }
}