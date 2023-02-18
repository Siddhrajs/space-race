using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour {

    public void Quit()
    {
        Debug.Log("QUIT!!");
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("lvl1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
