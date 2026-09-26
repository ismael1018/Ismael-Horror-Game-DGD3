using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance;
    public bool hasKey;

    private void Awake()
    {
        Instance = this;
    }
}