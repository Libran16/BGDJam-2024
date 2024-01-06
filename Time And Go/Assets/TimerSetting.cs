using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSetting : MonoBehaviour
{
    public Text TextTimer;
    public float Waktu = 100; //01:30

    public bool GameAktif = true;

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60); //1
        int Detik = Mathf.FloorToInt(Waktu % 60); //30
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    float s;

    private void Update()
    {
        if (GameAktif)
        {
            s+=Time.deltaTime;
            if(s>=1)
            {
                Waktu--;
                s = 0;
            }
        }

        if (GameAktif && Waktu <= 0)
        {
            Debug.Log("Game Kalah");
            GameAktif = false;
        }

        SetText();
    }
}
