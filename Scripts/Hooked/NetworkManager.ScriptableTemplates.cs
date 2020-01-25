// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using Wovencode;
using Wovencode.Network;
using Wovencode.Database;
using Wovencode.UI;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Mirror;

namespace Wovencode.Network
{

    // ===================================================================================
	// NetworkManager
	// ===================================================================================
	public partial class NetworkManager
	{
		
		// -------------------------------------------------------------------------------
		// Awake
		// -------------------------------------------------------------------------------
		[DevExtMethods("Awake")]
		void Awake_ScriptableTemplates()
		{
			
			// -- preload scriptable objects only if we are server & preloader available
#if _SERVER && !_CLIENT
			PreloadScriptableTemplates();
#endif
	
		}

		// -------------------------------------------------------------------------------
		// PreloadScriptableTemplates
		// -------------------------------------------------------------------------------
#if wTEMPLATES
		protected void PreloadScriptableTemplates()
    	{
       		PreloaderComponent preloader = GetComponent<PreloaderComponent>();
       		if (preloader)
        		preloader.PreloadTemplates();
    	}
#endif

		// -------------------------------------------------------------------------------

	}

}

// =======================================================================================