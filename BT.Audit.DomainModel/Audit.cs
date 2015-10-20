using System;

namespace BT.Audit.DomainModel
{
    public class Audit
    {
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
