
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Damageble player;
    [SerializeField] GameObject gameOverObject;
   
    void Update()
    {
        if (!player.IsAlive())
            gameOverObject.SetActive(true);
    }

    public void ResetScene()

    {
        SceneManager.LoadScene("MyFirstGame");
    }
}
