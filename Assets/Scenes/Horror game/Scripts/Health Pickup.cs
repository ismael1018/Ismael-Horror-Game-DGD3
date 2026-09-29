using UnityEngine;

public class HealthPickup : MonoBehaviour, IInteractable
{
    public int amount = 20;
   
    public void Interact()
    {
        PlayerHealth playerHealth = FindFirstObjectByType<PlayerHealth>();
        if (playerHealth != null)
            playerHealth.Heal(amount);

        Destroy(gameObject);
    }
}
