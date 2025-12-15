using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public int diamantesNecessarios = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Playerco player = other.GetComponent<Playerco>();

            if (player != null && player.GetDiamanteQtd() == diamantesNecessarios)
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                Debug.Log("Portal bloqueado! Colete 5 diamantes.");
            }
        }
    }
}
