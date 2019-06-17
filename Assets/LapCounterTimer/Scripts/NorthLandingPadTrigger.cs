using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Photon.Pun.Demo.PunBasics
{
    public class NorthLandingPadTrigger : MonoBehaviour
    {
        [SerializeField] ParticleSystem touchPadParticles;
        //[SerializeField] AudioClip touchLandingPad;
        //AudioSource audioSource;

        public GameObject NorthCompleteTrig;
        public GameObject EastCompleteTrig;
        public GameObject WestCompleteTrig;

        void OnTriggerEnter()
        {
            EastCompleteTrig.SetActive(true);
            WestCompleteTrig.SetActive(true);
            NorthCompleteTrig.SetActive(false);
            
            touchPadParticles.Play();
            //audioSource.PlayOneShot(touchLandingPad);
        }
    }
}