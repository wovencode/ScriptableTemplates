// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;
using Wovencode;

namespace Wovencode
{

	// ===================================================================================
	// RarityTemplateDictionary
	// ===================================================================================
	public partial class RarityTemplateDictionary
	{
		
		public readonly ReadOnlyDictionary<int, RarityTemplate> data;
		
		// -------------------------------------------------------------------------------
		public RarityTemplateDictionary(string folderName="")
		{
			List<RarityTemplate> templates = Resources.LoadAll<RarityTemplate>(folderName).ToList();
			
			if (templates.HasDuplicates())
				Debug.LogWarning("[Warning] Skipped loading due to duplicate(s) in Resources subfolder: " + folderName);
			else
				data = new ReadOnlyDictionary<int, RarityTemplate>(templates.ToDictionary(x => x.hash, x => x));
		}

		// -------------------------------------------------------------------------------
		
	}

}

// =======================================================================================
