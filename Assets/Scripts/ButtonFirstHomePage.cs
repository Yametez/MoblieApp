using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFirstHomePage : MonoBehaviour
{
    public void GoToGameCoin()
    {
        SceneManager.LoadScene("Coingame");
    }

    public void GoToLogin()
    {
        SceneManager.LoadScene("Login");
    }

    public void GoToHistoryExam()
    {
        SceneManager.LoadScene("HistoryExam"); // เปลี่ยนชื่อ Scene เป็น "HistoryExam"
    }
    public void GoToCardGame()
    {
        SceneManager.LoadScene("Card"); // เปลี่ยนชื่อ Scene เป็น "CardGame"
    }
    public void GoToHistoryCG()
    {
        SceneManager.LoadScene("HistoryCG"); // เปลี่ยนชื่อ Scene เป็น "HistoryCG"
    }
}