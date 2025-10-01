using UnityEngine;

public class AutoGun : MonoBehaviour
{
    public GameObject bulletPrefab;      // Mermi prefabı
    public Transform firePoint;          // Merminin çıkacağı nokta
    public Vector2 shootDirection = Vector2.right; // Atış yönü
    public float bulletSpeed = 10f;      // Mermi hızı
    public float fireRate = 0.5f;        // Kaç saniyede bir ateş edeceği

    private float nextFireTime = 0f;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = shootDirection.normalized * bulletSpeed;
            }
        }
    }
}
