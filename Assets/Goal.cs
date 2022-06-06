using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public GameObject particle;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject particle5;
    public GameObject particle6;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            clearText.SetActive(true);
            nextButton.SetActive(true);
            particle.SetActive(true);
            particle2.SetActive(true);
            particle3.SetActive(true);
            particle4.SetActive(true);
            particle5.SetActive(true);
            particle6.SetActive(true);
            audioSource.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
