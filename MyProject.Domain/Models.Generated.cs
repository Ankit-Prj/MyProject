


















#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;   
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Globalization;
using Sitecore.Data;

namespace MyProject.Domain.Models
{
	public partial interface IGlassBase{
		[SitecoreId]
		Guid Id{ get; }
		[SitecoreInfo(SitecoreInfoType.Language)]
        Language Language{ get; }
		[SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }
	}
	public abstract partial class GlassBase : IGlassBase{
		[SitecoreId]
		public virtual Guid Id{ get; private set;}
		[SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language{ get; private set; }
		[SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }
		[SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }
	}
}
namespace MyProject.Domain.Models.sitecore.templates.MyProject
{
 	/// <summary>
	/// IEmployee Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/MyProject/employee</para>	
	/// <para>ID: 1482d89b-1eca-46ef-b7d5-a526c8e05bd1</para>	
	/// </summary>
	[SitecoreType(TemplateId=IEmployeeConstants.TemplateIdString )] //, Cachable = true
	public partial interface IEmployee : IGlassBase 
	{
			
					/// <summary>
					/// The FirstName field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: f5721ea6-d3a1-4259-a364-718aa93b08fd</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IEmployeeConstants.FirstNameFieldName)]
					string FirstName  {get; set;}		
			
					/// <summary>
					/// The Lastname field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 18bc3692-a7e8-4fd3-b945-8b91337e2bc9</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IEmployeeConstants.LastnameFieldName)]
					string Lastname  {get; set;}		
			
	}
	public static partial class IEmployeeConstants{
			public const string TemplateIdString = "1482d89b-1eca-46ef-b7d5-a526c8e05bd1";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "employee";
		
			public static readonly ID FirstNameFieldId = new ID("f5721ea6-d3a1-4259-a364-718aa93b08fd");
			public const string FirstNameFieldName = "FirstName";
		
			public static readonly ID LastnameFieldId = new ID("18bc3692-a7e8-4fd3-b945-8b91337e2bc9");
			public const string LastnameFieldName = "Lastname";
		
	}
	
	/// <summary>
	/// Employee
	/// <para></para>
	/// <para>Path: /sitecore/templates/MyProject/employee</para>	
	/// <para>ID: 1482d89b-1eca-46ef-b7d5-a526c8e05bd1</para>	
	/// </summary>
	[SitecoreType(TemplateId=IEmployeeConstants.TemplateIdString)] //, Cachable = true
	public partial class Employee  : GlassBase, IEmployee 
	{
	   
				/// <summary>
				/// The FirstName field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: f5721ea6-d3a1-4259-a364-718aa93b08fd</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IEmployeeConstants.FirstNameFieldName)]
				public virtual string FirstName  {get; set;}
		
				/// <summary>
				/// The Lastname field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 18bc3692-a7e8-4fd3-b945-8b91337e2bc9</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IEmployeeConstants.LastnameFieldName)]
				public virtual string Lastname  {get; set;}
			
	}

}
namespace MyProject.Domain.Models.sitecore.templates.Sample
{
 	/// <summary>
	/// ISample_Item Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Sample/Sample Item</para>	
	/// <para>ID: 76036f5e-cbce-46d1-af0a-4143f9b557aa</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISample_ItemConstants.TemplateIdString )] //, Cachable = true
	public partial interface ISample_Item : IGlassBase 
	{
			
					/// <summary>
					/// The TextUpdated field.
					/// <para>ここにアイテムのテキストを入力してください</para>
					/// <para>Field Type: Rich Text</para>		
					/// <para>Field ID: a60acd61-a6db-4182-8329-c957982cec74</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISample_ItemConstants.TextUpdatedFieldName)]
					string TextUpdated  {get; set;}		
			
					/// <summary>
					/// The Title field.
					/// <para>ここにアイテムのタイトルを入力してください</para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 75577384-3c97-45da-a847-81b00500e250</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISample_ItemConstants.TitleFieldName)]
					string Title  {get; set;}		
			
	}
	public static partial class ISample_ItemConstants{
			public const string TemplateIdString = "76036f5e-cbce-46d1-af0a-4143f9b557aa";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Sample Item";
		
			public static readonly ID TextUpdatedFieldId = new ID("a60acd61-a6db-4182-8329-c957982cec74");
			public const string TextUpdatedFieldName = "TextUpdated";
		
			public static readonly ID TitleFieldId = new ID("75577384-3c97-45da-a847-81b00500e250");
			public const string TitleFieldName = "Title";
		
	}
	
	/// <summary>
	/// Sample_Item
	/// <para></para>
	/// <para>Path: /sitecore/templates/Sample/Sample Item</para>	
	/// <para>ID: 76036f5e-cbce-46d1-af0a-4143f9b557aa</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISample_ItemConstants.TemplateIdString)] //, Cachable = true
	public partial class Sample_Item  : GlassBase, ISample_Item 
	{
	   
				/// <summary>
				/// The TextUpdated field.
				/// <para>ここにアイテムのテキストを入力してください</para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: a60acd61-a6db-4182-8329-c957982cec74</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISample_ItemConstants.TextUpdatedFieldName)]
				public virtual string TextUpdated  {get; set;}
		
				/// <summary>
				/// The Title field.
				/// <para>ここにアイテムのタイトルを入力してください</para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 75577384-3c97-45da-a847-81b00500e250</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISample_ItemConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
			
	}

}
namespace MyProject.Domain.Models.sitecore.templates.Sample
{
 	/// <summary>
	/// I_New_Template Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Sample/_New template</para>	
	/// <para>ID: b75cf432-c529-438d-8b29-73734b02423b</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_New_TemplateConstants.TemplateIdString )] //, Cachable = true
	public partial interface I_New_Template : IGlassBase 
	{
			
	}
	public static partial class I_New_TemplateConstants{
			public const string TemplateIdString = "b75cf432-c529-438d-8b29-73734b02423b";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "_New template";
		
	}
	
	/// <summary>
	/// _New_Template
	/// <para></para>
	/// <para>Path: /sitecore/templates/Sample/_New template</para>	
	/// <para>ID: b75cf432-c529-438d-8b29-73734b02423b</para>	
	/// </summary>
	[SitecoreType(TemplateId=I_New_TemplateConstants.TemplateIdString)] //, Cachable = true
	public partial class _New_Template  : GlassBase, I_New_Template 
	{
	   	
	}

}
