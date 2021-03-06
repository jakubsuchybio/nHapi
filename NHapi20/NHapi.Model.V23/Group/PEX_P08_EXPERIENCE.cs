using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V23.Segment;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
///<summary>
///Represents the PEX_P08_EXPERIENCE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PES (Product Experience Sender) </li>
///<li>1: PEX_P08_PEX_OBSERVATION (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class PEX_P08_EXPERIENCE : AbstractGroup {

	///<summary> 
	/// Creates a new PEX_P08_EXPERIENCE Group.
	///</summary>
	public PEX_P08_EXPERIENCE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PES), true, false);
	      this.add(typeof(PEX_P08_PEX_OBSERVATION), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating PEX_P08_EXPERIENCE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PES (Product Experience Sender) - creates it if necessary
	///</summary>
	public PES PES { 
get{
	   PES ret = null;
	   try {
	      ret = (PES)this.GetStructure("PES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of PEX_P08_PEX_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public PEX_P08_PEX_OBSERVATION GetPEX_OBSERVATION() {
	   PEX_P08_PEX_OBSERVATION ret = null;
	   try {
	      ret = (PEX_P08_PEX_OBSERVATION)this.GetStructure("PEX_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PEX_P08_PEX_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PEX_P08_PEX_OBSERVATION GetPEX_OBSERVATION(int rep) { 
	   return (PEX_P08_PEX_OBSERVATION)this.GetStructure("PEX_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PEX_P08_PEX_OBSERVATION 
	 */ 
	public int PEX_OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PEX_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the PEX_P08_PEX_OBSERVATION results 
	 */ 
	public IEnumerable<PEX_P08_PEX_OBSERVATION> PEX_OBSERVATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < PEX_OBSERVATIONRepetitionsUsed; rep++)
			{
				yield return (PEX_P08_PEX_OBSERVATION)this.GetStructure("PEX_OBSERVATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new PEX_P08_PEX_OBSERVATION
	///</summary>
	public PEX_P08_PEX_OBSERVATION AddPEX_OBSERVATION()
	{
		return this.AddStructure("PEX_OBSERVATION") as PEX_P08_PEX_OBSERVATION;
	}

	///<summary>
	///Removes the given PEX_P08_PEX_OBSERVATION
	///</summary>
	public void RemovePEX_OBSERVATION(PEX_P08_PEX_OBSERVATION toRemove)
	{
		this.RemoveStructure("PEX_OBSERVATION", toRemove);
	}

	///<summary>
	///Removes the PEX_P08_PEX_OBSERVATION at the given index
	///</summary>
	public void RemovePEX_OBSERVATIONAt(int index)
	{
		this.RemoveRepetition("PEX_OBSERVATION", index);
	}

}
}
