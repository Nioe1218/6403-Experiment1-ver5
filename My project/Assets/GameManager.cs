using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static int PlayerScore1 = 3;
    

    public GUISkin layout;

GameObject theBall;
public static void Score (string wallID) {
   
        if (wallID == "BottomWall")
        {
            PlayerScore1--;
        }
    }
void OnGUI () {
    GUI.skin = layout;
    GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);


    if (GUI.Button(new Rect(Screen.width / 2 - 60, 35, 120, 53), "RESTART"))
    {
        PlayerScore1 = 0;
        
        theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
    }

    if (PlayerScore1 == 10)
    {
        GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
        theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
    }
        if (PlayerScore1 == 0)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "YOU LOSE");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }

    void Start()
    {
         theBall = GameObject.FindGameObjectWithTag("Ball");
}
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
