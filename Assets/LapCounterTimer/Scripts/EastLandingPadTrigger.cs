using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Photon.Pun.Demo.PunBasics
{
    public class EastLandingPadTrigger : MonoBehaviour
    {
        [SerializeField] ParticleSystem touchPadParticles;
        //[SerializeField] AudioClip touchLandingPad;
        //AudioSource audioSource;

        public GameObject SouthCompleteTrig;
        public GameObject NorthCompleteTrig;
        public GameObject EastCompleteTrig;

        void OnTriggerEnter()
        {
            SouthCompleteTrig.SetActive(true);
            NorthCompleteTrig.SetActive(true);
            EastCompleteTrig.SetActive(false);
            
            touchPadParticles.Play();
            //audioSource.PlayOneShot(touchLandingPad);
        }
    }
}