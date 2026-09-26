using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class Playerinteract : MonoBehaviour
{
    public float interactRange = 3f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, interactRange))
            {
                Door door = hit.collider.GetComponent<Door>();
                if (door != null)
                    door.Interact();

                KeyItem key = hit.collider.GetComponent<KeyItem>();
                if (key != null)
                    key.Interact();
            }
        }
    }
}
