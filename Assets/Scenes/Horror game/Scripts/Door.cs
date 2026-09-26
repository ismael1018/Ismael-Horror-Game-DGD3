using UnityEngine;
using static UnityEngine.Audio.GeneratorInstance;

public class Door : MonoBehaviour
{
    public bool isLocked = false;
    public bool onlyOpensFromInside = false; 

    private bool playerIsInside = false;

    public void Interact()
    {
        if (onlyOpensFromInside && !playerIsInside)
        {
            Debug.Log("This door won't open from this side.");
            return;
        }

        if (isLocked && !PlayerInventory.Instance.hasKey)
        {
            Debug.Log("The door is locked.");
            return;
        }

        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerIsInside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerIsInside = false;
    }
}
