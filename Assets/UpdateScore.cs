using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public TextMesh Score1Player;
    public TextMesh Score2Player;
    public TextMesh Score3Player;
    public TextMesh Score4Player;
    public TextMesh Score5Player;
    public TextMesh Score6Player;
    public TextMesh Score7Player;
    public TextMesh Score8Player;
    public TextMesh Score9Player;
    public TextMesh Score10Player;
    public TextMesh Score1;
    public TextMesh Score2;
    public TextMesh Score3;
    public TextMesh Score4;
    public TextMesh Score5;
    public TextMesh Score6;
    public TextMesh Score7;
    public TextMesh Score8;
    public TextMesh Score9;
    public TextMesh Score10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //update scores
        Score1.text = (Score.FirstScore).ToString();
        Score2.text = (Score.SecondScore).ToString();
        Score3.text = (Score.ThirdScore).ToString();
        Score4.text = (Score.FourthScore).ToString();
        Score5.text = (Score.FifthScore).ToString();
        Score6.text = (Score.SixthScore).ToString();
        Score7.text = (Score.SeventhScore).ToString();
        Score8.text = (Score.EighthScore).ToString();
        Score9.text = (Score.NinethScore).ToString();
        Score10.text = (Score.TenthScore).ToString();
        

        //update player names
        Score1Player.text = Score.FirstPlayer;
        Score2Player.text = Score.SecondPlayer;
        Score3Player.text = Score.ThirdPlayer;
        Score4Player.text = Score.FourthPlayer;
        Score5Player.text = Score.FifthPlayer;
        Score6Player.text = Score.SixthPlayer;
        Score7Player.text = Score.SeventhPlayer;
        Score8Player.text = Score.EighthPlayer;
        Score9Player.text = Score.NinethPlayer;
        Score10Player.text = Score.TenthPlayer;

    }
}
