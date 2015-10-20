using System;

namespace BT.Audit.DomainModel
{
	/// <summary>
	/// Representation of an Auditable Event
	/// </summary>
    public class Audit
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="category"></param>
	    public Audit(string category)
	    {
		    Timestamp = DateTime.UtcNow;
		    Category = category;
	    }

		/// <summary>
		/// Timestamp
		/// </summary>
		public DateTime Timestamp { get; private set; }
		
		/// <summary>
		/// Category
		/// </summary>
		public string Category { get; private set; }
    }
}
