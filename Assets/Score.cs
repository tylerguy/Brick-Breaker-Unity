using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int FirstScore = 0;
    public static int SecondScore = 0;
    public static int ThirdScore = 0;
    public static int FourthScore = 0;
    public static int FifthScore = 0;
    public static int SixthScore = 0;
    public static int SeventhScore = 0;
    public static int EighthScore = 0;
    public static int NinethScore = 0;
    public static int TenthScore = 0;
    public int TempFirstScore;
    public int TempSecondScore;
    public int TempThirdScore;
    public int TempFourthScore;
    public int TempFifthScore;
    public int TempSixthScore;
    public int TempSeventhScore;
    public int TempEighthScore;
    public int TempNinethScore;
    public int TempTenthScore;
    public static string FirstPlayer = "Name1";
    public static string SecondPlayer = "Name2";
    public static string ThirdPlayer = "Name3";
    public static string FourthPlayer = "Name4";
    public static string FifthPlayer = "Name5";
    public static string SixthPlayer = "Name6";
    public static string SeventhPlayer = "Name7";
    public static string EighthPlayer = "Name8";
    public static string NinethPlayer = "Name9";
    public static string TenthPlayer = "Name10";
    public string TempFirstPlayer;
    public string TempSecondPlayer;
    public string TempThirdPlayer;
    public string TempFourthPlayer;
    public string TempFifthPlayer;
    public string TempSixthPlayer;
    public string TempSeventhPlayer;
    public string TempEighthPlayer;
    public string TempNinethPlayer;
    public string TempTenthPlayer;

    private void Update()
    {
        
        if (FirstScore < SecondScore)
        {
            //update score
            TempFirstScore = SecondScore;
            SecondScore = FirstScore;
            FirstScore = TempFirstScore;
            //update player names
            TempFirstPlayer = SecondPlayer;
            SecondPlayer = FirstPlayer;
            FirstPlayer = TempFirstPlayer;

        }
        if (SecondScore < ThirdScore)
        {
            //update score
            TempSecondScore = ThirdScore;
            ThirdScore = SecondScore;
            SecondScore = TempSecondScore;
            //update player names
            TempSecondPlayer = ThirdPlayer;
            ThirdPlayer = SecondPlayer;
            SecondPlayer = TempSecondPlayer;
        }
        if (ThirdScore < FourthScore)
        {
            //update score
            TempThirdScore = FourthScore;
            FourthScore = ThirdScore;
            ThirdScore = TempThirdScore;
            //update player names
            TempThirdPlayer = FourthPlayer;
            FourthPlayer = ThirdPlayer;
            ThirdPlayer = TempThirdPlayer;
        }
        if (FourthScore < FifthScore)
        {
            //update score
            TempFourthScore = FifthScore;
            FifthScore = FourthScore;
            FourthScore = TempFourthScore;
            //update player names
            TempFourthPlayer = FifthPlayer;
            FifthPlayer = FourthPlayer;
            FourthPlayer = TempFourthPlayer;
        }
        if (FifthScore < SixthScore)
        {
            //update score
            TempFifthScore = SixthScore;
            SixthScore = FifthScore;
            FifthScore = TempFifthScore;
            //update player names
            TempFifthPlayer = SixthPlayer;
            SixthPlayer = FifthPlayer;
            FifthPlayer = TempFifthPlayer;
        }
        if (SixthScore < SeventhScore)
        {
            TempSixthScore = SeventhScore;
            SeventhScore = SixthScore;
            SixthScore = TempSixthScore;
            //update player names
            TempSixthPlayer = SeventhPlayer;
            SeventhPlayer = SixthPlayer;
            SixthPlayer = TempSixthPlayer;
        }
        if (SeventhScore < EighthScore)
        {
            TempSeventhScore = EighthScore;
            EighthScore = SeventhScore;
            SeventhScore = TempSeventhScore;
            //update player names
            TempSeventhPlayer = EighthPlayer;
            EighthPlayer = SeventhPlayer;
            SeventhPlayer = TempSeventhPlayer;
        }
        if (EighthScore < NinethScore)
        {
            TempEighthScore = NinethScore;
            NinethScore = EighthScore;
            EighthScore = TempEighthScore;
            //update player names
            TempEighthPlayer = NinethPlayer;
            NinethPlayer = EighthPlayer;
            EighthPlayer = TempEighthPlayer;
        }
        if (NinethScore < TenthScore)
        {
            TempNinethScore = TenthScore;
            TenthScore = NinethScore;
            NinethScore = TempNinethScore;
            //update player names
            TempNinethPlayer = TenthPlayer;
            TenthPlayer = NinethPlayer;
            NinethPlayer = TempNinethPlayer;
        }
    }
}
