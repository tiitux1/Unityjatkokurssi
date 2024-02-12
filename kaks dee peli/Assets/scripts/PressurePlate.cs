using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject wallToRemove; // Sein‰, joka poistetaan painelevyn aktivoituessa

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Tarkista, onko pelaaja astunut painelevylle
        {
            if (wallToRemove != null)
            {
                // Poista sein‰, jos se on m‰‰ritetty
                wallToRemove.SetActive(false);
            }
        }
    }
}
