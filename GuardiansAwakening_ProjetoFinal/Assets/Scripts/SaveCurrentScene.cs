using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveCurrentScene : MonoBehaviour
{
    private void Awake()
    {
        string cenaAtual = SceneManager.GetActiveScene().name;

        // Só salva fases jogáveis
        if (cenaAtual.StartsWith("Fase"))
        {
            PlayerPrefs.SetString("UltimaFase", cenaAtual);
            PlayerPrefs.Save();

            Debug.Log("Última fase salva: " + cenaAtual);
        }
    }
}