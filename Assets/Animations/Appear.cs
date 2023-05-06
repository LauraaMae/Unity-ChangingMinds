using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject ManMoves;

        void Start()
        {
            ManMoves.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
        {
           
           ManMoves.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
           ManMoves.SetActive(false);
        }
    }
}
