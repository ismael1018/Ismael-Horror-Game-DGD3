using UnityEngine;

public class KeyItem : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        PlayerInventory.Instance.hasKey = true;
        Destroy(gameObject);
    }
}