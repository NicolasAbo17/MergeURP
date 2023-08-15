using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewSetting
{
    public class NewClient : MonoBehaviour
    {
        public static bool day = false;
        public static bool night = false;

        public static bool city = false;
        public static bool ocean = false;


        public static bool rain = false;
        public static bool sunny = false;

        [PunRPC] public void SetDay()
        {
            day = true;
            night = false;
            Debug.Log("Day, true");
        }
        [PunRPC] public void SetNight()
        {
            night = true;
            day = false;
            Debug.Log("Night, true");
        }
        [PunRPC] public void SetCity()
        {
            city = true;
            ocean = false;
            Debug.Log("City, true");
        }
        [PunRPC] public void SetOcean()
        {
            ocean = true;
            city = false;
            Debug.Log("Ocean, true");
        }
        [PunRPC] public void SetRainy()
        {
            rain = true;
            sunny = false;
            Debug.Log("Rainy, true" );
        }
        [PunRPC] public void SetSunny()
        {
            sunny = true;
            rain = false;
            Debug.Log("Sunny, true");
        }
    }
}
