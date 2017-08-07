using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {


	public void StartGame (){
		SceneManager.LoadScene(1);
	}
}
