using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header("Hareket Ayarlarý")]
    public float moveSpeed = 2f;       // Hareket hýzý
    public float patrolDistance = 3f;  // Gitmek istediði mesafe

    private Vector2 startPos;          // Baþlangýç pozisyonu
    private bool movingRight = true;   // Baþlangýç yönü

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            if (transform.position.x >= startPos.x + patrolDistance)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (transform.position.x <= startPos.x - patrolDistance)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1; // Düþmaný yatay eksende çevirir
        transform.localScale = scale;
    }
}
