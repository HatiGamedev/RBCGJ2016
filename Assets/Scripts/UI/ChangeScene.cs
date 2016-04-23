using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void Change(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
