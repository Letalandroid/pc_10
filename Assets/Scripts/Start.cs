using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("Game");
    }
}
