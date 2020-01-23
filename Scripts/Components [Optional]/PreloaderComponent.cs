// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using Wovencode;
using Wovencode.DebugManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class PreloaderComponent : MonoBehaviour
{
	
	public ScriptableTemplate[] preloadTemplates;
	
	public bool preloadOnAwake;
	
	// -----------------------------------------------------------------------------------
	// Awake
	// -----------------------------------------------------------------------------------
    void Awake()
    {
    	if (preloadOnAwake)
    		PreloadTemplates();
    }
    
	// -----------------------------------------------------------------------------------
	// PreloadTemplates
	// -----------------------------------------------------------------------------------
	public void PreloadTemplates()
	{
		
		foreach (ScriptableTemplate template in preloadTemplates)
		{
			Type t = template.GetType();
			MethodInfo m = t.GetMethod("BuildCache");
			m.Invoke(this, new object[]{true});


		}	
		
	}
	
	// -----------------------------------------------------------------------------------
	
}
