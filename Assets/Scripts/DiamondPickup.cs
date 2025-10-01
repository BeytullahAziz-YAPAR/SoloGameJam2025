using UnityEngine;

public class DiamondPickup : MonoBehaviour
{
    public GameObject endPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (endPoint != null)
                endPoint.SetActive(true);

            Destroy(gameObject);
        }
    }
}
