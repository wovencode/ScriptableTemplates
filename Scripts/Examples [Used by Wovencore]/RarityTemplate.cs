// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using wovencode;

namespace wovencode {
	
	// ===================================================================================
	// BaseTemplate
	// ===================================================================================
	[CreateAssetMenu(fileName = "New Rarity", menuName = "Templates/New Rarity", order = 999)]
	public partial class RarityTemplate : ScriptableTemplate
	{
		
		public Color			color;
		public Sprite			borderImage;
		
		// -------------------------------------------------------------------------------
		
		public static string _folderName = "";	
		
		static Dictionary<int, RarityTemplate> _data;
		
		// -------------------------------------------------------------------------------
        // data
        // -------------------------------------------------------------------------------
		public static Dictionary<int, RarityTemplate> data
		{
			get {
				RarityTemplate.BuildCache();
				return _data;
			}
		}
		
		// -------------------------------------------------------------------------------
        // BuildCache
        // -------------------------------------------------------------------------------
		public static void BuildCache()
		{
			if (_data != null) return;

			List<RarityTemplate> templates = Resources.LoadAll<RarityTemplate>(RarityTemplate._folderName).ToList();
					
			if (templates.HasDuplicates())
				Debug.LogWarning("[Warning] Skipped loading due to duplicate(s) in Resources subfolder: " + RarityTemplate._folderName);
			else
				_data = templates.ToDictionary(x => x.hash, x => x);
			
		}
		
		// -------------------------------------------------------------------------------
        // OnEnable
        // -------------------------------------------------------------------------------
		public void OnEnable()
		{
			if (_folderName != folderName)
				_folderName = folderName;
		}
		
		// -------------------------------------------------------------------------------
        // OnValidate
        // -------------------------------------------------------------------------------
		public override void OnValidate()
		{
			base.OnValidate();
		}
		
		// -------------------------------------------------------------------------------
		
	}

}

// =======================================================================================