using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}



// STICKY PLATFORM

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);    // player as a child of moving platfrom
        }

    }

    private void OnTriggerExit2D(Collider2D collision) {

        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);    // player as a child of moving platfrom
        } 

    }
}
