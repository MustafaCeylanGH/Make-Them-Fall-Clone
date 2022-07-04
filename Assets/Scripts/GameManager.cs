using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretxt;

    private int score = 0;
    
    public void UpScore()
    {
        score++;
        scoretxt.text = score.ToString();
    }
}
