using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour//ゲームシーンの遷移を行う
{
	public void StartGame()
	{
		SceneManager.LoadScene("Gamescene");
		ResultScore.gamemode = 1;
		ResultScore.result = 0;
		ResultScore.ranking = 0;
		TuneInfo.ddelta = 0;
	}
	public void StartSetting()
	{
		SceneManager.LoadScene("playersetting");
	}
	public void ChooseMode()
	{
		SceneManager.LoadScene("modechoose");
	}
	public void CreateScene()
	{
		SceneManager.LoadScene("CreateScene");
	}
	public void Tunechoose()
	{
		SceneManager.LoadScene("TuneChoose");
	}
	public void Tutorial()
	{
		SceneManager.LoadScene("Tutorial");
		ResultScore.gamemode = 1;
		ResultScore.result = 0;
		ResultScore.ranking = 0;
		TuneInfo.ddelta = 0;
	}
	public void EndGame()
	{
		Application.Quit();
	}
	void Update()
    {

    }
}
