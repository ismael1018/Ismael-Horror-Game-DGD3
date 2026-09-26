using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public void Interact()
    {
        PlayerInventory.Instance.hasKey = true;
        Destroy(gameObject);
    }
}