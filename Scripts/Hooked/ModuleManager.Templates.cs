// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

#if UNITY_EDITOR

using Wovencode;
using Wovencode.Modules;
using UnityEditor;
using UnityEngine;

namespace Wovencode.Modules
{
	
	// ===================================================================================
	// ModuleManager
	// ===================================================================================
	public partial class ModuleManager
	{
		
		// -------------------------------------------------------------------------------
		// Constructor
		// -------------------------------------------------------------------------------
		[DevExtMethods("Constructor")]
		public static void Constructor_Templates()
		{
			
			Module module = new Module();
			
			module.name				= "ScriptableTemplates";
			module.define			= "wTEMPLATES";
			module.version       	= "PreAlpha1";
			module.unity3dVersion 	= "2018.x-2019.x";
			module.nameSpace		= "Wovencode";
        	module.package         	= "Wovencore";
        	module.author        	= "Fhiz";
        	module.dependencies  	= "wTOOLS";
       		module.comments      	= "none";
        	
        	AddModule(module);
        	
		}

	}

}

#endif

// =======================================================================================