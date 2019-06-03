using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour
{	
	public AudioSource soundSource;

    public void ResetScene (string SceneName)
	{
		// Reset the scene when the user clicks the sign post
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
        soundSource.Play();
	}
}