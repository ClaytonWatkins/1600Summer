using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loadlevel : MonoBehaviour {

	public void PlayAgain (){
		SceneManager.LoadScene(1);
	}
}