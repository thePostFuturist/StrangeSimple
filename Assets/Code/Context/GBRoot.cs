using System;
using UnityEngine;
using strange.extensions.context.impl;

namespace cubeattractor {
	public class GBRoot: ContextView
	{
		void Awake()
		{
			context = new GBContext (this);
		}
	}
}