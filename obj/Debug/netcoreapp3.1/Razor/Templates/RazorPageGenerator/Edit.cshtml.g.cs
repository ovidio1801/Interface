#pragma checksum "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff89de748080766e78b2d3062c68f1bc59060b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_Edit), @"mvc.1.0.view", @"/Templates/RazorPageGenerator/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff89de748080766e78b2d3062c68f1bc59060b4", @"/Templates/RazorPageGenerator/Edit.cshtml")]
    public class Templates_RazorPageGenerator_Edit : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@page\r\n");
            WriteLiteral("@model ");
#nullable restore
#line 6 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
   Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 6 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                        Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
  
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
#line 15 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                      Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 16 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 18 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 19 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 22 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
 Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
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
#line 36 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
        Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>");
#nullable restore
#line 42 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
 Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("<hr />\r\n");
            WriteLiteral("<div class=\"row\">\r\n    ");
            WriteLiteral("<div class=\"col-md-4\">\r\n        ");
            WriteLiteral("<form method=\"post\">\r\n            ");
            WriteLiteral("<div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
#nullable restore
#line 48 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
        foreach (PropertyMetadata property in Model.ModelMetadata.Properties)
        {
            if (property.IsPrimaryKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 52 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 52 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 53 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                continue;
            }

            if (property.Scaffold)
            {
                if (property.IsReadOnly)
                {
                    continue;
                }

                if (property.IsForeignKey)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 67 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                               Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 67 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                     Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" asp-items=\"ViewBag.");
#nullable restore
#line 67 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                                                                                     Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></select>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 68 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 68 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 70 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                    continue;
                }

                bool isCheckbox = property.TypeName.Equals("System.Boolean");
                if (isCheckbox)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group form-check\">\r\n                ");
            WriteLiteral("<label class=\"form-check-label\">\r\n                    ");
            WriteLiteral("<input class=\"form-check-input\" asp-for=\"");
#nullable restore
#line 78 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                           Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 78 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                                                 Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" /> ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 78 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                                                                                                                  Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 78 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                                                                                                                                        Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                ");
            WriteLiteral("</label>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 81 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                }
                else if (property.IsEnum && !property.IsEnumFlags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 85 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 85 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 86 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                               Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 86 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                     Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></select>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 87 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 87 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 89 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                }
                else if (property.IsMultilineText)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 93 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 93 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<textarea asp-for=\"");
#nullable restore
#line 94 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                 Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 94 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></textarea>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 95 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 95 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 97 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 101 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 101 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<input asp-for=\"");
#nullable restore
#line 102 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 102 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" />\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 103 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 103 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 105 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                }
            }
            // Ideally we shouldn't be here  but if the user marks the foreign key as [ScaffoldColumn(false)], we want to atleast try to make it work.
            else if (property.IsForeignKey)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 110 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                    Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 110 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                                                          Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 111 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
                continue;
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n\r\n");
#nullable restore
#line 126 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
  
    if (Model.ReferenceScriptLibraries)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@section Scripts {\r\n    ");
            WriteLiteral("@{await Html.RenderPartialAsync(\"_ValidationScriptsPartial\");}\r\n");
            WriteLiteral("}\r\n");
#nullable restore
#line 132 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
    }
    // The following code closes the tag used in the case of a view using a layout page and the body and html tags in the case of a regular view page
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 138 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 141 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Edit.cshtml"
 
    string GetAssociationName(IPropertyMetadata property)
    {
        //Todo: Implement properly.
        return property.PropertyName;
    }

    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
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
