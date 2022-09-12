/************************************************************
■【Unity】スクリプトを Editor 上で動作させる
	https://hacchi-man.hatenablog.com/entry/2020/09/10/220000
	
■スクリプトを Edit モードで実行
	https://qiita.com/okuhiiro/items/0121fc26c0b80a4673a0

■ExecuteInEditMode
	https://docs.unity3d.com/ScriptReference/ExecuteInEditMode.html
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[ExecuteInEditMode]
public class test : MonoBehaviour
{
	int c_Update = 0;
	int c_GUI = 0;
	int c_RenderObject = 0;
	
	void Awake()
	{
		Debug.Log("Awake");
	}
	void Start()
	{
		Debug.Log("Start");
		
	}

	void Update()
	{
		/*
		string str_Message = String.Format("Update : {0}", c_Update);
		Debug.Log(str_Message);
		c_Update++;
		*/
		
		if(Input.GetKeyDown(KeyCode.Alpha0)){
			Debug.Log("key = 0 : pressed");
		}
	}
	
	void OnRenderObject ()
	{
		/*
		string str_Message = String.Format("OnRenderObject : {0}", c_RenderObject);
		Debug.Log(str_Message);
		c_RenderObject++;
		*/
	}	
	
	void OnGUI(){
	/*
		string str_Message = String.Format("OnGUI : {0}", c_GUI);
		Debug.Log(str_Message);
		c_GUI++;
	*/
	}
}
