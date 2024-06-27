using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTriggers : MonoBehaviour
{
   private void OnTriggerEnter2D( Collider2D collision ) {
      if ( collision.tag == "DeadZone" ) {
         SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
      }
   }
}
