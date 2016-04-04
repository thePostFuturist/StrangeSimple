using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;
using strange.extensions.mediation.impl;

namespace cubeattractor
{

	public class CubeAttractorView: View, ICubeAttractorView {

		public float speed;

		bool is_attracted;

		void Update () {
			if (is_attracted == false) {
				CheckForThingsAheadOfCube ();
				MoveCube ();
			}
		}

		void CheckForThingsAheadOfCube()
		{
			RaycastHit hit_info;
			if (Physics.Raycast (transform.position, Vector3.forward, out hit_info)) {
				if (hit_info.distance < 1) {
					DispatchAttractionMade();
					is_attracted = true;
				}
			}
		}

		void MoveCube()
		{
			transform.localPosition += Vector3.forward * speed * Time.deltaTime;
		}

		void DispatchAttractionMade()
		{
			if (onAttractionMade != null)
				onAttractionMade (true);	
		}

		public event System.Action<bool> onAttractionMade;
	}

	public interface ICubeAttractorView {
		event System.Action<bool> onAttractionMade;
	}
}

  