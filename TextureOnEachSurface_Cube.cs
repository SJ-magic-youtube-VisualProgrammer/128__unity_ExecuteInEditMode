/************************************************************
■【UnityC#】Cubeの各面に異なるテクスチャを貼る方法
	https://edunity.hatenablog.com/entry/20200530/1590819049
	
■【Unity】Cube の6面にテクスチャを割り当てる
	https://kazupon.org/unity-cube-xi-texture/
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
【Unity】スクリプトを Editor 上で動作させる
	https://hacchi-man.hatenablog.com/entry/2020/09/10/220000
************************************************************/
[ExecuteInEditMode]
public class TextureOnEachSurface_Cube : MonoBehaviour
{
	Mesh mesh = null;
	private Vector2[] UV = new Vector2[24];
	
	void Start()
	{
		/********************
		********************/
		//y+
		UV[ 5] = new Vector2(0.0f / 6.0f, 0.0f);
		UV[ 9] = new Vector2(0.0f / 6.0f, 1.0f);
		UV[ 8] = new Vector2(1.0f / 6.0f, 1.0f);
		UV[ 4] = new Vector2(1.0f / 6.0f, 0.0f);
		
		//x-
		UV[16] = new Vector2(1.0f / 6.0f, 0.0f);
		UV[17] = new Vector2(1.0f / 6.0f, 1.0f);
		UV[18] = new Vector2(2.0f / 6.0f, 1.0f);
		UV[19] = new Vector2(2.0f / 6.0f, 0.0f);
		
		//x+
		UV[20] = new Vector2(2.0f / 6.0f, 0.0f);
		UV[21] = new Vector2(2.0f / 6.0f, 1.0f);
		UV[22] = new Vector2(3.0f / 6.0f, 1.0f);
		UV[23] = new Vector2(3.0f / 6.0f, 0.0f);
		
		//z-
		UV[ 7] = new Vector2(3.0f / 6.0f, 0.0f);
		UV[11] = new Vector2(3.0f / 6.0f, 1.0f);
		UV[10] = new Vector2(4.0f / 6.0f, 1.0f);
		UV[ 6] = new Vector2(4.0f / 6.0f, 0.0f);
		
		//z+
		UV[ 0] = new Vector2(4.0f / 6.0f, 0.0f);
		UV[ 2] = new Vector2(4.0f / 6.0f, 1.0f);
		UV[ 3] = new Vector2(5.0f / 6.0f, 1.0f);
		UV[ 1] = new Vector2(5.0f / 6.0f, 0.0f);
		
		//y-
		UV[14] = new Vector2(5.0f / 6.0f, 0.0f);
		UV[15] = new Vector2(5.0f / 6.0f, 1.0f);
		UV[12] = new Vector2(6.0f / 6.0f, 1.0f);
		UV[13] = new Vector2(6.0f / 6.0f, 0.0f);
		
		/********************
		■gameObject.GetComponent<Transform>() と transform の違い（または Unity における省略記法について）
			https://qiita.com/megane42/items/9709d696e8f2561dbb1d
			
		■MeshFilter.mesh
			https://docs.unity3d.com/ja/2020.3/ScriptReference/MeshFilter-mesh.html
			
		■Mesh vs Shared Mesh in procedural generation
			https://forum.unity.com/threads/mesh-vs-shared-mesh-in-procedural-generation.583957/
		********************/
		// this.gameObject.transform.GetComponent<MeshFilter>().mesh.uv = UV;
		// transform.GetComponent<MeshFilter>().mesh.uv = UV;
		// this.gameObject.GetComponent<MeshFilter>().mesh.uv = UV;
		GetComponent<MeshFilter>().mesh.uv = UV;
		mesh = GetComponent<MeshFilter>().mesh;
		
		// GetComponent<MeshFilter>().sharedMesh.uv = UV;
	}
	
	void Update(){
		if(Input.GetKeyDown(KeyCode.D)){
			if(mesh != null) Destroy(mesh);
		}
	}
	
	private void OnDestroy(){
		if(mesh != null){
			Debug.Log("Destroyed created mesh");
			Destroy(mesh);
		}
	}
}
