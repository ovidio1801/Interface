#pragma checksum "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5da623b34281f60879ac609f803e1ae20a78bdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_Versioned_Bootstrap3_List), @"mvc.1.0.view", @"/Templates/RazorPageGenerator_Versioned/Bootstrap3/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5da623b34281f60879ac609f803e1ae20a78bdd", @"/Templates/RazorPageGenerator_Versioned/Bootstrap3/List.cshtml")]
    public class Templates_RazorPageGenerator_Versioned_Bootstrap3_List : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@page\r\n");
            WriteLiteral("@model ");
#nullable restore
#line 6 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
   Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 6 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                        Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
  
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
#line 15 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                      Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 16 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 18 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 19 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h2>");
#nullable restore
#line 22 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
 Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
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
#line 36 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
        Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
#nullable restore
#line 39 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            WriteLiteral("<a asp-page=\"Create\">Create New</a>\r\n");
            WriteLiteral("</p>\r\n");
            WriteLiteral("<table class=\"table\">\r\n    ");
            WriteLiteral("<thead>\r\n        ");
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 47 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
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
            WriteLiteral("            <th>\r\n                ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 56 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                 Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("[0].");
#nullable restore
#line 56 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                                          Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </th>\r\n");
#nullable restore
#line 58 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
            }
            else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\r\n                ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 62 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                 Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("[0].");
#nullable restore
#line 62 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                                          Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </th>\r\n");
#nullable restore
#line 64 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<th></th>\r\n        ");
            WriteLiteral("</tr>\r\n    ");
            WriteLiteral("</thead>\r\n    ");
            WriteLiteral("<tbody>\r\n");
            WriteLiteral("@foreach (var item in Model.");
#nullable restore
#line 70 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                           Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(") {\r\n        ");
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 72 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
        foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
        {
            if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
                && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            WriteLiteral("@Html.DisplayFor(modelItem => item.");
#nullable restore
#line 78 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                               Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </td>\r\n");
#nullable restore
#line 80 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
            }
            else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            WriteLiteral("@Html.DisplayFor(modelItem => item.");
#nullable restore
#line 84 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                               Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 84 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                                               Write(navigation.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </td>\r\n");
#nullable restore
#line 86 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
            }
        }
        string pkName = GetPrimaryKeyName();
        if (pkName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<td>\r\n                ");
            WriteLiteral("<a asp-page=\"./Edit\" asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 92 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                       Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a> |\r\n                ");
            WriteLiteral("<a asp-page=\"./Details\" asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 93 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                          Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Details</a> |\r\n                ");
            WriteLiteral("<a asp-page=\"./Delete\" asp-route-id=\"");
            WriteLiteral("@item.");
#nullable restore
#line 94 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
                                                         Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a>\r\n            ");
            WriteLiteral("</td>\r\n");
#nullable restore
#line 96 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            WriteLiteral("@Html.ActionLink(\"Edit\", \"Edit\", new { /* id=item.PrimaryKey */ }) |\r\n                ");
            WriteLiteral("@Html.ActionLink(\"Details\", \"Details\", new { /* id=item.PrimaryKey */ }) |\r\n                ");
            WriteLiteral("@Html.ActionLink(\"Delete\", \"Delete\", new { /* id=item.PrimaryKey */ })\r\n            </td>\r\n");
#nullable restore
#line 104 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("</tr>\r\n");
            WriteLiteral("}\r\n    ");
            WriteLiteral("</tbody>\r\n");
            WriteLiteral("</table>\r\n");
#nullable restore
#line 110 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
    if(!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 115 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\List.cshtml"
 
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

    string GetEnumerableTypeExpression(string typeName)
    {
        return "IEnumerable<" + typeName + ">";
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
