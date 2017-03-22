using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets._2D
{
    public class scirpt : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                PlatformerCharacter2D speed = other.GetComponent<PlatformerCharacter2D>();
                speed.setSpeed();
                Destroy(gameObject);
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}