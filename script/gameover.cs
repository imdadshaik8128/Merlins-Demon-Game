using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
	public void Mainmenu()
	{
		SceneManager.LoadScene(0);
	}

}
