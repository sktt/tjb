using UnityEngine;
using System.Collections;

public class FBXScaleFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	using UnityEngine;
	using UnityEditor;
	
	class MeshPostprocessor : AssetPostprocessor {
		
		void OnPreprocessModel () {
			(assetImporter as ModelImporter).globalScale = 1000;
		}
		
	}
}
