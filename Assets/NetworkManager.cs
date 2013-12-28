using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	public Camera standbyCamera;	

	// Use this for initialization
	void Start () {
		Connect ();
	}

	void Connect () {
		PhotonNetwork.ConnectUsingSettings( "1.0.0" );

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
		PhotonNetwork.Instantiate ("PlayerController", Vector3.zero, Quaternion.identity, 0);
		standbyCamera.enabled = false;
		}
}

