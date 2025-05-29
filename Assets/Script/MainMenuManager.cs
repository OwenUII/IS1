using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("StartGame ถูกเรียกแล้ว"); // พิมพ์ข้อความทดสอบ
        SceneManager.LoadScene("GameScene");
    }
}
