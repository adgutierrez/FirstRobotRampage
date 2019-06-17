using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Photon.Pun.Demo.PunBasics
{
    public class WestLandingPadTrigger : MonoBehaviour
    {
        [SerializeField] ParticleSystem touchPadParticles;
        //[SerializeField] AudioClip touchPadParticles;
        //AudioSource audioSource;

        public GameObject SouthCompleteTrig;
        public GameObject NorthCompleteTrig;
        public GameObject WestCompleteTrig;

        void OnTriggerEnter()
        {
            SouthCompleteTrig.SetActive(true);
            NorthCompleteTrig.SetActive(true);
            WestCompleteTrig.SetActive(false);

            touchPadParticles.Play();
            //audioSource.PlayOneShot(touchLandingPad);
        }
    }
}