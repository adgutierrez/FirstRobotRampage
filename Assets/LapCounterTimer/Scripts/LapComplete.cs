using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Photon.Pun.Demo.PunBasics
{
    public class LapComplete : MonoBehaviour
    {
        [SerializeField] ParticleSystem touchPadParticles;

        public GameObject SouthCompleteTrig;
        public GameObject NorthCompleteTrig;
        public GameObject EastCompleteTrig;
        public GameObject WestCompleteTrig;

        public GameObject MinuteDisplay;
        public GameObject SecondDisplay;
        public GameObject MilliDisplay;
        public GameObject LapTimeBox;
        public GameObject LapCounter;
        public int LapDone;
        public float RawTime;


        void OnTriggerEnter()
        {
            LapDone += 1;
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.RawTime <= RawTime)
            {
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                }

                if (LapTimeManager.MinuteCount <= 9)
                {
                     MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
                }
                MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
            }
            PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MiliSave", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            LapTimeManager.RawTime = 0;

            LapCounter.GetComponent<Text>().text = "" + LapDone;

            NorthCompleteTrig.SetActive(false);
            SouthCompleteTrig.SetActive(false);
            EastCompleteTrig.SetActive(true);
            WestCompleteTrig.SetActive(true);
            touchPadParticles.Play();
        }
        


    }
}