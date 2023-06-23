using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddScores : MonoBehaviour
{
    TMP_Text text_Score;
    int _score;
    public static AddScores create { get; private set; }


    // Start is called before the first frame update
    void Awake()
    {
        text_Score = GetComponent<TMP_Text>();
        if(create!=null&& create != this)
        {
            Destroy(this);
        }
        else
        {
            create = this;
        }
        
    }
    public void add_Score(int p)
    {
        _score += p;
        text_Score.text= _score.ToString();
    }
}
