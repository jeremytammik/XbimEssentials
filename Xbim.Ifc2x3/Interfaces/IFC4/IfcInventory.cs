// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	public partial class @IfcInventory : IIfcInventory
	{
		Xbim.Ifc4.SharedFacilitiesElements.IfcInventoryTypeEnum? IIfcInventory.PredefinedType 
		{ 
			get
			{
				switch (InventoryType)
				{
					case Xbim.Ifc2x3.SharedFacilitiesElements.IfcInventoryTypeEnum.ASSETINVENTORY:
						return Xbim.Ifc4.SharedFacilitiesElements.IfcInventoryTypeEnum.ASSETINVENTORY;
					
					case Xbim.Ifc2x3.SharedFacilitiesElements.IfcInventoryTypeEnum.SPACEINVENTORY:
						return Xbim.Ifc4.SharedFacilitiesElements.IfcInventoryTypeEnum.SPACEINVENTORY;
					
					case Xbim.Ifc2x3.SharedFacilitiesElements.IfcInventoryTypeEnum.FURNITUREINVENTORY:
						return Xbim.Ifc4.SharedFacilitiesElements.IfcInventoryTypeEnum.FURNITUREINVENTORY;
					
					case Xbim.Ifc2x3.SharedFacilitiesElements.IfcInventoryTypeEnum.USERDEFINED:
						return Xbim.Ifc4.SharedFacilitiesElements.IfcInventoryTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.SharedFacilitiesElements.IfcInventoryTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.SharedFacilitiesElements.IfcInventoryTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.ActorResource.IfcActorSelect IIfcInventory.Jurisdiction 
		{ 
			get
			{
				if (Jurisdiction == null) return null;
				var ifcorganization = Jurisdiction as Xbim.Ifc2x3.ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = Jurisdiction as Xbim.Ifc2x3.ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = Jurisdiction as Xbim.Ifc2x3.ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
		}
		IEnumerable<IIfcPerson> IIfcInventory.ResponsiblePersons 
		{ 
			get
			{
			foreach (var member in ResponsiblePersons)
			{
				yield return member as IIfcPerson;
			}
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDate? IIfcInventory.LastUpdateDate 
		{ 
			get
			{
				//TODO: Handle return of LastUpdateDate for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IIfcCostValue IIfcInventory.CurrentValue 
		{ 
			get
			{
				return CurrentValue as IIfcCostValue;
			} 
		}
		IIfcCostValue IIfcInventory.OriginalValue 
		{ 
			get
			{
				return OriginalValue as IIfcCostValue;
			} 
		}
	}
}