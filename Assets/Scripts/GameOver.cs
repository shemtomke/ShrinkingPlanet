using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    void Update ()
	{
		/*if((Input.touchCount > 0 || Input.GetMouseButton(0)) && GameManager.instance.isGameOver)
        {
			GameManager.instance.Restart();
		}*/

		//GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
	}
	public void Restart()
    {
		GameManager.instance.Restart();
	}
	public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

}
