using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject titleButton;
    public GameObject resetButton;

    public bool moveVec = false;
    public float moveSpeed;
    public float startWaitTimer;
    public float waitTimer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -3)
        {
            waitTimer = startWaitTimer;
            moveVec = true;
            transform.position = new Vector3(15, 1, -3.0f);
        }
        if (transform.position.z > 13.5)
        {
            waitTimer = startWaitTimer;
            moveVec = false;
            transform.position = new Vector3(15, 1, 13.5f);
        }

        if (waitTimer > 0)
        {
            waitTimer--;
            moveSpeed = 0;
        }
        else
        {
            moveSpeed = 0.05f;
        }

        if (moveVec == false)
            transform.position -= new Vector3(0, 0, moveSpeed);
        if (moveVec == true)
            transform.position += new Vector3(0, 0, moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameOverText.SetActive(true);
            titleButton.transform.localPosition = new Vector3(0, -80, 0);
            resetButton.transform.localPosition = new Vector3(0, -160, 0);

            Destroy(other.gameObject);
        }
    }
}
