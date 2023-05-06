using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStopAnimation : MonoBehaviour
{


    public Animator MovingCar;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           // MovingCar.Pause();
           MovingCar.SetFloat("carSpeed" , 0);

    
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
           MovingCar.SetFloat("carSpeed" , 1);
        }
    }

    
}
