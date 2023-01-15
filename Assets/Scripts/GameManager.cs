using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI, joystick;
	public bool isGameOver = false;
	void Awake ()
	{
		instance = this;
	}

	public void EndGame ()
	{
		isGameOver = true;
		gameOverUI.SetActive(true);
		joystick.SetActive(false);
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
