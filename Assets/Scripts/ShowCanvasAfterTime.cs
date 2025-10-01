using UnityEngine;

public class ShowCanvasAfterTime : MonoBehaviour
{
    public GameObject canvasObject; // Canvas objesini Inspector’dan atayacaksýn
    public float delay = 15f;       // Gecikme süresi

    void Start()
    {
        if (canvasObject != null)
            canvasObject.SetActive(false); // Baþta gizle

        Invoke("ShowCanvas", delay);
    }

    void ShowCanvas()
    {
        if (canvasObject != null)
            canvasObject.SetActive(true); // 15 saniye sonra aç
    }
}
