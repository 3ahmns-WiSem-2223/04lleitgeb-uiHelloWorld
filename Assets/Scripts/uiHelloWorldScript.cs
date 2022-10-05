using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class uiHelloWorldScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int zahl;

    public void nextScene()
        {
            SceneManager.LoadScene(1);
        }


    public void addNumber()
    {
        zahl = zahl + 1;
        score.text = zahl.ToString();
    }


    public void subtractNumber()
    {
        zahl = zahl - 1;
        score.text = zahl.ToString();
    }

}
