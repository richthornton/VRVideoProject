using UnityEngine;
using System.Collections;

public class webcamScript : MonoBehaviour {
	
	//The texture that holds the video captured by the webcam
	private WebCamTexture webCamTexture;
	
	// Use this for initialization
	void Start () 
	{
		//Initialize the webCamTexture
		webCamTexture = new WebCamTexture();
		//Assign the images captured by the first available webcam as the texture of the containing game object
		GetComponent<Renderer>().material.mainTexture = webCamTexture;
		//Start streaming the images captured by the webcam into the texture
		webCamTexture.Play();
	}
}