using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.PropertyResource
{
	public partial class IfcPropertyEnumeration : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.PropertyResource.IfcPropertyEnumeration");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcPropertyEnumeration clause) {
			var retVal = false;
			if (clause == Where.IfcPropertyEnumeration.WR01) {
				try {
					retVal = SIZEOF(this.EnumerationValues.Where(temp => !(TYPEOF(this.EnumerationValues.ToArray()[0]) == TYPEOF(temp)))) == 0;
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcPropertyEnumeration.WR01' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcPropertyEnumeration.WR01))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPropertyEnumeration.WR01", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcPropertyEnumeration
	{
		public static readonly IfcPropertyEnumeration WR01 = new IfcPropertyEnumeration();
		protected IfcPropertyEnumeration() {}
	}
}