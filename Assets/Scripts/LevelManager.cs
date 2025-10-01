using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Bir sonraki sahneye geç
    public void LoadNextLevel()
    {
        Time.timeScale = 1f;
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    // Mevcut sahneyi yeniden yükle
    public void RestartLevel()
    {
        Time.timeScale = 1f;
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex);
    }

    // Tek tek Level sahneleri
    public void LoadLevel1() { Time.timeScale = 1f; SceneManager.LoadScene("Level1"); }
    public void LoadLevel2() { Time.timeScale = 1f; SceneManager.LoadScene("Level2"); }
    public void LoadLevel3() { Time.timeScale = 1f; SceneManager.LoadScene("Level3"); }
    public void LoadLevel4() { Time.timeScale = 1f; SceneManager.LoadScene("Level4"); }
    public void LoadLevel5() { Time.timeScale = 1f; SceneManager.LoadScene("Level5"); }
    public void LoadLevel6() { Time.timeScale = 1f; SceneManager.LoadScene("Level6"); }
    public void LoadLevel7() { Time.timeScale = 1f; SceneManager.LoadScene("Level7"); }
    public void LoadLevel8() { Time.timeScale = 1f; SceneManager.LoadScene("Level8"); }
    public void LoadLevel9() { Time.timeScale = 1f; SceneManager.LoadScene("Level9"); }
    public void LoadLevel10() { Time.timeScale = 1f; SceneManager.LoadScene("Level10"); }
    public void LoadLevel11() { Time.timeScale = 1f; SceneManager.LoadScene("Level11"); }
    public void LoadLevel12() { Time.timeScale = 1f; SceneManager.LoadScene("Level12"); }
    public void LoadLevel13() { Time.timeScale = 1f; SceneManager.LoadScene("Level13"); }
    public void LoadLevel14() { Time.timeScale = 1f; SceneManager.LoadScene("Level14"); }
    public void LoadLevel15() { Time.timeScale = 1f; SceneManager.LoadScene("Level15"); }
    public void LoadLevel16() { Time.timeScale = 1f; SceneManager.LoadScene("Level16"); }
    public void LoadLevel17() { Time.timeScale = 1f; SceneManager.LoadScene("Level17"); }
    public void LoadLevel18() { Time.timeScale = 1f; SceneManager.LoadScene("Level18"); }
    public void LevelMenu() { Time.timeScale = 1f; SceneManager.LoadScene("Level Menu"); }
    public void MainMenu() { Time.timeScale = 1f; SceneManager.LoadScene("Main Menu"); }
    public void Quit(){ Application.Quit();}
}
