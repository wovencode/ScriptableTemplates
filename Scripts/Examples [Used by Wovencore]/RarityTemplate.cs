// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using System;
using System.Collections.ObjectModel;
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
		
		static RarityTemplateDictionary _data;
		
		// -------------------------------------------------------------------------------
        // data
        // -------------------------------------------------------------------------------
		public static ReadOnlyDictionary<int, RarityTemplate> data
		{
			get {
				RarityTemplate.BuildCache();
				return _data.data;
			}
		}
		
		// -------------------------------------------------------------------------------
        // BuildCache
        // -------------------------------------------------------------------------------
		public static void BuildCache()
		{
			if (_data == null)
				_data = new RarityTemplateDictionary(RarityTemplate._folderName);
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