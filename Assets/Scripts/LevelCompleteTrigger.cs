using UnityEngine;

public class LevelCompleteTrigger : MonoBehaviour
{
    public GameObject completePanel; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (completePanel != null)
                completePanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }
}
