#pragma checksum "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ddacdaeff0befd3b6a89f6fc7ad6d925b624a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_Versioned_Bootstrap3_Delete), @"mvc.1.0.view", @"/Templates/RazorPageGenerator_Versioned/Bootstrap3/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ddacdaeff0befd3b6a89f6fc7ad6d925b624a6", @"/Templates/RazorPageGenerator_Versioned/Bootstrap3/Delete.cshtml")]
    public class Templates_RazorPageGenerator_Versioned_Bootstrap3_Delete : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@page\r\n");
            WriteLiteral("@model ");
#nullable restore
#line 6 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
   Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 6 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                        Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
  
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
#line 15 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                      Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 16 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 18 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 19 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h2>");
#nullable restore
#line 22 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
 Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
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
#line 36 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
        Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>");
#nullable restore
#line 45 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
   Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n");
#nullable restore
#line 48 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
  
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
            WriteLiteral("        <dt>\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 58 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                             Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 58 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                                                   Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd>\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 61 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                         Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 61 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                                               Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 63 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
        }
        else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 67 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                             Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 67 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                                                   Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd>\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 70 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                         Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 70 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                                               Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 70 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                                                                               Write(navigation.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 72 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("</dl>\r\n    ");
            WriteLiteral("\r\n    ");
            WriteLiteral("<form method=\"post\">\r\n");
#nullable restore
#line 77 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
        foreach (var property in Model.ModelMetadata.Properties)
        {
            if(property.IsPrimaryKey){

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 80 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                    Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 80 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
                                                          Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 81 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
            WriteLiteral("<a asp-page=\"./Index\">Back to List</a>\r\n    ");
            WriteLiteral("</form>\r\n");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 87 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 92 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\PROYECTOS\RRHH\Templates\RazorPageGenerator_Versioned\Bootstrap3\Delete.cshtml"
 
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
