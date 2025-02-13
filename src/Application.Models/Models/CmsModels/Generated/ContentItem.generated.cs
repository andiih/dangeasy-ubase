//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Application.Models.Models.CmsModels
{
	/// <summary>ContentItem</summary>
	[PublishedModel("contentItem")]
	public partial class ContentItem : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "contentItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentItem(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// ContentBody
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentBody")]
		public string ContentBody => this.Value<string>("contentBody");

		///<summary>
		/// ContentDate
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentDate")]
		public DateTime ContentDate => this.Value<DateTime>("contentDate");

		///<summary>
		/// ContentGroup
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentGroup")]
		public string ContentGroup => this.Value<string>("contentGroup");

		///<summary>
		/// ContentID
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentID")]
		public int ContentID => this.Value<int>("contentID");

		///<summary>
		/// ContentImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentImage")]
		public string ContentImage => this.Value<string>("contentImage");

		///<summary>
		/// ContentImageAlt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentImageAlt")]
		public string ContentImageAlt => this.Value<string>("contentImageAlt");

		///<summary>
		/// ContentImageLink
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentImageLink")]
		public string ContentImageLink => this.Value<string>("contentImageLink");

		///<summary>
		/// ContentTag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentTag")]
		public string ContentTag => this.Value<string>("contentTag");

		///<summary>
		/// ContentTeaser
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentTeaser")]
		public string ContentTeaser => this.Value<string>("contentTeaser");

		///<summary>
		/// ContentTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentTitle")]
		public string ContentTitle => this.Value<string>("contentTitle");

		///<summary>
		/// ContentTitleLink
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentTitleLink")]
		public string ContentTitleLink => this.Value<string>("contentTitleLink");

		///<summary>
		/// ContentTypeId
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentTypeId")]
		public int ContentTypeId => this.Value<int>("contentTypeId");

		///<summary>
		/// Enabled
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("enabled")]
		public bool Enabled => this.Value<bool>("enabled");

		///<summary>
		/// RegionId
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("regionId")]
		public int RegionId => this.Value<int>("regionId");

		///<summary>
		/// Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("section")]
		public string Section => this.Value<string>("section");

		///<summary>
		/// SortKey
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sortKey")]
		public int SortKey => this.Value<int>("sortKey");
	}
}
