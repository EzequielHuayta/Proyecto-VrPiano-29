using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int currentScore;

public int scorePerNote = 100;
public int miss = 0;
public int actualmiss = 1;

public int currentMultiplier;
public int multiplierTracker;

public int[] multiplierThresholds;
public static GameManager instance;
public TextMeshProUGUI scoreText;
public TextMeshProUGUI missText;
public TextMeshProUGUI multiText;

public float totalNotes;

public GameObject resultsScreen;

public TextMeshProUGUI percentHitText, missesText, rankText, finalScoreText;
    // Start is called before the first frame update

void Update() 
{
    resultsScreen.SetActive(true);
    finalScoreText.text= "" + currentScore;
    missesText.text= "" + miss;

    float totalHit = currentScore/100;
    float percentHit = (totalHit / totalNotes) * 100f;

    percentHitText.text = percentHit.ToString("F1") + "%";

    string rankVal = "F";

    if(percentHit > 40)
    {
        rankVal = "D";
        if(percentHit > 60)
        {
            rankVal="C";
            if(percentHit > 75)
            {
                rankVal = "B";
                if(percentHit > 90)
                {
                    rankVal = "A";
                    if(percentHit > 95)
                    {
                        rankVal = "S";
                    }
                }
            }
        }
    rankText.text = rankVal;
    }
}
    void Start()
    {
        instance=this;
        currentMultiplier = 1;
        totalNotes = FindObjectsOfType<NoteObject>().Length;
    }
    public void NoteHit()
    {
        if(currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;
                if(multiplierThresholds[currentMultiplier -  1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier ++;
            }
        }

    multiText.text = "Multiplier: x" + currentMultiplier;
    currentScore += scorePerNote * currentMultiplier;
    scoreText.text = "Score " + currentScore;
    }

    public void NoteMissed()
    {
        miss += actualmiss;
        missText.text = "Miss " + miss;
        currentMultiplier = 1;
        multiplierTracker = 0;
        multiText.text = "Multiplier: x" + currentMultiplier;
    }
}
