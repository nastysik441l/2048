using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
public static GameController Instance;

public static int Points{get; private set;}

public static bool GameStarted { get; private set;}

[SerializeField] private TextMeshProUGUI gameResult;

[SerializeField] private TextMeshProUGUI pointsText;

private void Awake()
{
    if(Instance== null)
    Instance=this;
}



public void Win()
{
    GameStarted=false;
gameResult.text="YOU WIN";
}

public void Lose()
{
    GameStarted=false;
    gameResult.text="YOU LOSE";
}

public void StartGame()
{
    gameResult.text="";
    SetPoints(0);
    GameStarted=true;
    Field.Instance.GenerateField();

}


 public void AddPoints( int points)
{
SetPoints(Points+points);
}

public void SetPoints(int points)
{
    Points=points;

    pointsText.text=Points.ToString();
}

}
