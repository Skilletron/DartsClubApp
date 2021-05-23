using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public PlayerController playerController;
    public Text name_winner;
    public Animator Winner_animation;
    public int[] winner;


    public void Update()
    {
        for (int i = 0; i < playerController.Score.Length; i++){
         winner[i] = int.Parse(playerController.Score[i].text);
            if(winner[i] <= 0)
            {
                name_winner.GetComponent<Text>().text = playerController.Name[i].text;
                Winner_animation.SetBool("PlayerWin", true);
}
        }
    }
    public void OnClickButtonRestart()
    {
        Winner_animation.SetBool("PlayerWin", false);
        Application.LoadLevel("Game");
    }
}
