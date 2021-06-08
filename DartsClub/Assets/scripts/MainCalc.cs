using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainCalc : MonoBehaviour
{
    public string x,temp;
    public int result, counter, player,maxresult;
    public int[] small_score;
    public PlayerController playerController;
    public GameMode gameMode;
    public AudioSource audio;
    public GameObject Error;
    public Animator Error_animation;
    public AudioClip clip;

 
    public void Start()
    {
        temp = "0";
        maxresult = 0;
        player = 0;
        playerController.Player_image[player].GetComponent<Image>().color = new Color(1f, 0.5f, 0.5f);
    }
    public void Calc(string x)
    {
        audio.PlayOneShot(clip);
        temp += x;
        
    }
    public void Calc_Help(string x)
    {
        audio.PlayOneShot(clip);
        if (int.Parse(temp) >= 0)
        {
            temp = "0";
        }

        temp = x;
    }
    public void ClickButtonOk()
    {
        audio.PlayOneShot(clip);
        result = int.Parse(temp);
        temp = "0";
        if (result > 180)
        {
            result = 0;
            Error_animation.Play("Errror_Anim_Start");
            Error_animation.SetBool("error", true);
       


        }
        Error_animation.SetBool("error", false);
        if (result != 0)
        {
            counter++;
            gameMode.Gamemode[player] = gameMode.Gamemode[player] - result;
            small_score[player] += result;
            playerController.small_score[player].GetComponent<Text>().text = small_score[player].ToString();
            playerController.Counter[player].GetComponent<Text>().text = counter.ToString();
            playerController.Score[player].GetComponent<Text>().text = gameMode.Gamemode[player].ToString();
            playerController.Score_History[player].GetComponent<Text>().text += " " + result;
        }
        if (gameMode.Gamemode[player] <= 0)
        {
            playerController.Score[player].GetComponent<Text>().text = "0";
        }
     


    }
    public void ClickButtonClear()
    {
        audio.PlayOneShot(clip);
        temp = "0";
        result = 0;
    }
    public void Update()
    {
 
        if (counter >= 3)
        {
            if(result > maxresult)
            {
                maxresult = result;
            }

            counter = 0;
            result = 0;
            player++;
            playerController.Counter[player - 1].GetComponent<Text>().text = "0";
            for(int c = 0;c != playerController.Player.Length; c++)
            {
                playerController.Player_image[c].GetComponent<Image>().color = new Color(1f, 1f, 1f);
            }
            playerController.Player_image[player].GetComponent<Image>().color = new Color(1f, 0.5f, 0.5f);
           
        
        }
        if (player == playerController.i)
        {
            player = 0;
            for (int c = 0; c != playerController.Player.Length; c++)
            {
                playerController.Player_image[c].GetComponent<Image>().color = new Color(1f, 1f, 1f);
            }
            playerController.Player_image[player].GetComponent<Image>().color = new Color(1f, 0.5f, 0.5f);
    
        }

    }
}

