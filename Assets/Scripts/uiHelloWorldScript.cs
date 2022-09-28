using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class uiHelloWorldScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score;
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

    public AudioSource soundPlayer;

    public void playSound()
    {
        soundPlayer.Play();
    }

}
