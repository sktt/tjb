using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	public Camera standbyCamera;

	// Use this for initialization
	void Start () {
		Connect ();
		this.standbyCamera = GameObject.Find ("StandbyCamera").camera;
	}

	void Connect () {
		PhotonNetwork.ConnectUsingSettings( "1.0.1" );

	}

	void OnGUI() {
		GUILayout.Label( PhotonNetwork.connectionStateDetailed.ToString () );
	}

	void OnJoinedLobby() {
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed() {
		PhotonNetwork.CreateRoom (null);
	}

	void OnJoinedRoom() {
		Debug.Log ("OnJoinedLobby");
		SpawnMyPlayer ();
	}

	void SpawnMyPlayer() {
		GameObject playerGO = (GameObject)PhotonNetwork.Instantiate ("PlayerChar", new Vector3(3,50,3), Quaternion.identity, 0);
		((MonoBehaviour)playerGO.GetComponent("FPSInputController")).enabled = true;
		((MonoBehaviour)playerGO.GetComponent("MouseLook")).enabled = true;
		((MonoBehaviour)playerGO.GetComponent("CharacterMotor")).enabled = true;
		//Debug.Log (playerGO.transform.FindChild("Main Camera").gameObject.camera);
		playerGO.transform.FindChild ("Main Camera").gameObject.SetActive(true);
		standbyCamera.enabled = false;
	}
}

