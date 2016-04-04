using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;
using strange.extensions.mediation.impl;

namespace cubeattractor
{

	public class CubeManagerView: View, ICubeManagerView {

		public void AcceptAttraction(bool state)
		{
			Debug.Log ("cube attracted");

			if (state==true)
				ChangeColor ();
		}

		void ChangeColor()
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.green;
		}

	}

	public interface ICubeManagerView {
		void AcceptAttraction(bool state);
	}
}

  