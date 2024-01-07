using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collactable : MonoBehaviour
{
    ScoreManager scoreManager;
    public AudioSource OilSound;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.IncreaseScore();
            scoreManager.HighScore();
            gameObject.SetActive(false);
            OilSound.Play();
            
        }
    }
}
