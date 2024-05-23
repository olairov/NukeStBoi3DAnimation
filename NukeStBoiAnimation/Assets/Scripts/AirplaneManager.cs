using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneManager : MonoBehaviour
{
    public void CleanSmoke()
    {
        transform.Find("Boost/Smoke").GetComponent<ParticleSystem>().Clear();
    }
}
