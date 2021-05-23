using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    public PlayerController playerController;
    public int[] Gamemode;
    public AudioSource audio;
    public AudioClip clip;
    public void Start()
    {
        for (int i = 0; i < playerController.Score.Length; i++)
        {
            Gamemode[i] = 1;
            playerController.Score[i].GetComponent<Text>().text = Gamemode[i].ToString();

        }
    }
    public void GameMode_301()
    {
        audio.PlayOneShot(clip);
        for (int i = 0; i < playerController.Score.Length; i++) {
            Gamemode[i] = 301;
            playerController.Score[i].GetComponent<Text>().text = Gamemode[i].ToString() ;

        }
    }
    public void GameMode_501()
    {
        audio.PlayOneShot(clip);
        for (int i = 0; i < playerController.Score.Length; i++)
        {
            Gamemode[i] = 501;
            playerController.Score[i].GetComponent<Text>().text = Gamemode[i].ToString();
        }
    }
    public void GameMode_1001()
    {
        audio.PlayOneShot(clip);
        for (int i = 0; i < playerController.Score.Length; i++)
        {
            Gamemode[i] = 1001;
            playerController.Score[i].GetComponent<Text>().text = Gamemode[i].ToString();
        }
    }
}
