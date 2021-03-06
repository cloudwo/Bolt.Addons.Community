
# Bolt.Addons.Community
A community-driven project for extending Unity Bolt with custom nodes, types, and helpers.

Development is open to the community.


#### Why Bolt.Addons.Community and not Bolt.Community.Addons?  
While the latter flows off of the tongue more naturally, this project aims to be part of a larger ecosystem of addons and so aims for the former.  If auto-adding custom types from namespaces becomes a supported feature of Bolt, Bolt.Addons.X is preferable.

> [Direct Download (requires matching Bolt version)](https://github.com/RealityStop/Bolt.Addons.Community/releases/)



----------

## Installing

Import the provided .assetpackage into your project, then and regenerate.  There is no need to add anything to the assembly or type options.  "Build Unit Options" is required before the units will be available.

> **Important:** Version 2 is structured significantly different from prior versions.  See the [Upgrade Guide](https://github.com/RealityStop/Bolt.Addons.Community/wiki/Version-2.0-Released!) for more information.


## What's included
There are two .unitypackages delivered currently:

> ### Bolt.Addons.Community.Fundamentals

/Variables
 - **Increment Variable**
 - **Decrement Variable**
 - **Plus Equals**

/Events
 - **On Every X Seconds**
 - **On Variable Changed**
 - **Manual Event** -- *(new in 2.3)*

/Documentation
 - **Todo**
 - **Stuff Happens**
 - **Comment**

/Collections
 - **Random Numbers** -- *Improved!*

/Control
 - **Branch Equal** -- *Now in the Branch (Params)*
 - **Branch Greater** -- *Now in the Branch (Params)*
 - **Branch Less** -- *Now in the Branch (Params)*
 - **Branch Next** -- *Now in the Branch (Params)*
 - **Branch (Params)** -- *Improved!*
 - **Gate**
 - **Edge Trigger**
 - **Change Detect**
 - **DoOnce**

/Logic
 - **Latch**
 - **Polarity**
 - **Between**
 - **Logic (Params)**

/Math
 - **Math Op**
 - 
	 /Functions  (Still in testing, feel free to make suggestions, though!)
	 - **Decay**
	 - **Exponential**
	 - **Linear**
	 - **Logarithmic**
	 - **Reverse Linear**
	 - **Sigmoid**

> ### Bolt.Addons.Community.Events  (Officially moved to its own page - http://lifeandstylemedia.com/tutorials/bolt/assets/returnevent_downloads.php)



## How do I use it?
See the documentation!  Once you've rebuilt your unit options, the new nodes will be available for use.  The repository wiki details each node added.  If we've missed anything, send us a message!


# For Developers:

## How to build
To build the addons for Bolt version {targetversion}.  Add the following dlls from your Unity Project with {targetversion} of Bolt installed:

\Dependencies\BoltBinaries\\{targetversion}
 - Bolt.*.dll  
 - Ludiq.*.dll
(from (*Assets\Ludiq\Assemblies*) )
  
\Dependencies\UnityBinaries
 - UnityEditor.dll
 - UnityEngine.CoreModule.dll
 - UnityEngine.dll
 - UnityEngine.UI.dll
 
 ![](https://i.imgur.com/M7XvCRl.gif)

Open and build the \src\Bolt.Addons.Community.sln solution in Visual Studio 2017, selecting the Release_{targetversion} solution configuration.

The binaries will be copied to \Output\\{targetversion}


## Current contributors (aka who to blame)
 - *Reality.Stop()
 - *JasonJamesLASM
 - Necka
 - Eka
 - Silence
