#pragma checksum "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e2c8ff6526dfab1c78e0218b31cb0091e46b46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_Details), @"mvc.1.0.view", @"/Templates/RazorPageGenerator/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e2c8ff6526dfab1c78e0218b31cb0091e46b46", @"/Templates/RazorPageGenerator/Details.cshtml")]
    public class Templates_RazorPageGenerator_Details : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@page\r\n");
            WriteLiteral("@model ");
#nullable restore
#line 6 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
   Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 6 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                        Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
  
    if (Model.IsPartialView)
    {
    }
    else if (Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 15 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                      Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 16 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 18 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 19 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 22 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
 Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("Layout = null;\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            WriteLiteral("<head>\r\n    ");
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
            WriteLiteral("<title>");
#nullable restore
#line 36 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
        Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4>");
#nullable restore
#line 44 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
   Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 47 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
  
    Dictionary<string, IPropertyMetadata> propertyLookup = ((IModelMetadata)Model.ModelMetadata).Properties.ToDictionary(x => x.PropertyName, x => x);
    Dictionary<string, INavigationMetadata> navigationLookup = ((IModelMetadata)Model.ModelMetadata).Navigations.ToDictionary(x => x.AssociationPropertyName, x => x);

    foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
    {
        if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
            && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 57 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                             Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 57 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                                                   Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 60 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                         Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 60 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                                               Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 62 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
        }
        else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                             Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                                                   Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 69 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                         Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 69 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                                               Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 69 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                                                                               Write(navigation.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 71 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 76 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
  
    string pkName = GetPrimaryKeyName();
    if (pkName != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("<a asp-page=\"./Edit\" asp-route-id=\"");
            WriteLiteral("@Model.");
#nullable restore
#line 80 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                             Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 80 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
                                                                   Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a> |\r\n    ");
            WriteLiteral("<a asp-page=\"./Index\">Back to List</a>\r\n");
#nullable restore
#line 82 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("@Html.ActionLink(\"Edit\", \"Edit\", new { /* id = Model.PrimaryKey */ }) |\r\n    ");
            WriteLiteral("<a asp-page=\"./Index\">Back to List</a>\r\n");
#nullable restore
#line 87 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 89 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
  
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 95 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Details.cshtml"
 
    string GetPrimaryKeyName()
    {
        return (Model.ModelMetadata.PrimaryKeys != null && Model.ModelMetadata.PrimaryKeys.Length == 1)
        ? Model.ModelMetadata.PrimaryKeys[0].PropertyName
        : null;
    }

    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
    }

    string GetValueExpression(INavigationMetadata navigation)
    {
        return navigation.AssociationPropertyName;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
