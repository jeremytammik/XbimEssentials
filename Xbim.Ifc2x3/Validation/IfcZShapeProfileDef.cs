using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using static Xbim.Ifc2x3.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class IfcZShapeProfileDef : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.ProfileResource.IfcZShapeProfileDef");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcZShapeProfileDef clause) {
			var retVal = false;
			if (clause == Where.IfcZShapeProfileDef.WR21) {
				try {
					retVal = FlangeThickness < (Depth / 2);
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcZShapeProfileDef.WR21' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcZShapeProfileDef.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcZShapeProfileDef.WR21", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcZShapeProfileDef
	{
		public static readonly IfcZShapeProfileDef WR21 = new IfcZShapeProfileDef();
		protected IfcZShapeProfileDef() {}
	}
}