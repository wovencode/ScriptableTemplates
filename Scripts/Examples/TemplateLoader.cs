// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using Wovencode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateLoader : MonoBehaviour
{
	
	/*
	
		This is just a example to demonstrate how template loading and caching works
		
		In a real project you DO NOT require the TemplateLoader, as the templates are
		simply loaded into memory the first time they are accessed.
	
		Add this script to a GameObject in your scene and hit Play, then take a look
		at the log.
		
	*/
	
	public string templateNameFoo 	= "FooTemplate1";
	public string templateNameBar 	= "BarTemplate1";
	
	[Header("Debug Mode")]
	public DebugHelper debug;
	
	// -----------------------------------------------------------------------------------
	// Awake
	// -----------------------------------------------------------------------------------
    void Awake()
    {
    	if (debug.debugMode)
    	{
    		LoadFoo();
    		LoadBar();
    		LoadSingleton();
    	}
    }
    
	// -----------------------------------------------------------------------------------
	// LoadSpells
	// This example triggers caching of templates by accessing one of it by its name
	// -----------------------------------------------------------------------------------
	void LoadFoo()
	{
	
		Debug.Log("----- LOAD FOO -----");
		Debug.Log("Trying to load all FooTemplates by accessing one by name...");
    	
    	FooTemplate.data.TryGetValue(templateNameFoo.GetDeterministicHashCode(), out FooTemplate template);
    	
        if (template)
        	Debug.Log("The FooTemplate '"+template.title+"' was found in the 'FooTemplate' Dictionary");
        else
        	Debug.Log("No FooTemplate named '"+templateNameFoo+"' was found!");
        
        Debug.Log("A total of '"+FooTemplate.data.Count+"' FooTemplates have been cached from '"+FooTemplate._folderName+"' into the Dictionary.");
	}
	
	// -----------------------------------------------------------------------------------
	// LoadBar
	// This example uses the 'BuildCache' method on the template class to cache them
	// -----------------------------------------------------------------------------------
	void LoadBar()
	{
	
		Debug.Log("----- LOAD BAR -----");
		Debug.Log("Trying to load all BarTemplates by using 'BuildCache'...");
    	
    	BarTemplate.BuildCache();
    	
        Debug.Log("A total of '"+BarTemplate.data.Count+"' BarTemplates have been cached from '"+BarTemplate._folderName+"' into the Dictionary.");
	}
	
	// -----------------------------------------------------------------------------------
	// LoadSingleton
	// 
	// -----------------------------------------------------------------------------------
	void LoadSingleton()
	{
		Debug.Log("----- LOAD GAME RULES -----");
		Debug.Log("Trying to access GameRulesTemplate via Singleton...");
		Debug.Log("maxPlayersPerUser: "+GameRulesTemplate.singleton.maxPlayersPerUser);
		Debug.Log("maxUsersPerDevice: "+GameRulesTemplate.singleton.maxUsersPerDevice);
		Debug.Log("maxUsersPerEmail: "+GameRulesTemplate.singleton.maxUsersPerEmail);
	}
	
	// -----------------------------------------------------------------------------------
	
}
