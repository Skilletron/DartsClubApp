using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int i,NumberPlayer;
    public Transform Content;
    public InputField Player_Name;
    public Text[] Name;
    public Text[] Score;
    public Text[] Counter;
    public Text[] small_score;
    public Text[] Name_History;
    public Text[] Score_History;
    public Image[] Player_image;
    public GameObject[] Player;
    public GameObject AddPlayer;
    public GameObject[] Player_History;
    public MainCalc mainCalc;
    public AudioSource audio;
    public AudioClip clip;

    private void Start()
    {
        NumberPlayer = -1;
        i = 0;
        mainCalc.player = 0;
        mainCalc.counter = 0;
    }
    public void OnClickButton_AddPlayer()
    {
        audio.PlayOneShot(clip);
        Player[i].SetActive(true);
        Player_History[i].SetActive(true);
        NumberPlayer++;
        i++;
        if (i == 33)
        {
         AddPlayer.SetActive(false);
        }
     

    }
 

}