using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    public GameObject youWinText;
    public float delay;






    // Start is called before the first frame update
    void Start()
    {
        youWinText.SetActive(false);
    }
   public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player");
            youWinText.SetActive(true);
            StartCoroutine(Countdown());
        }
    }
    IEnumerator Countdown()
    {
        Debug.Log(delay);
        yield return new WaitForSeconds (delay);
        SceneManager.LoadScene(0);
    }



    
}
