using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject playerPrefab;
    private GameObject spawnedPlayer;

    void Start()
    {
        if (playerPrefab != null && spawnedPlayer == null)
        {
            spawnedPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity);
        }
    }
}
