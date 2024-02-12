using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger: MonoBehaviour
{
    // T�m� metodi kutsutaan, kun pelaaja osuu maaliin
    private void OnTriggerEnter(Collider other)
    {
        // Tarkistetaan, osuiko pelaaja maaliin
        if (other.CompareTag("Player"))
        {
            // Ladataan seuraava taso nimelt� "TasoKaksi"
            SceneManager.LoadScene("TasoKaksi");
        }
    }
}