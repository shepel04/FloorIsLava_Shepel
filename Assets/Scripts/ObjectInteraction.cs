using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject objectToShow;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            //need to work
            if (objectToShow != null)
            {
                objectToShow.SetActive(true);

            }
        }
    }
}