#pragma checksum "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e34e8d652b76ab889f488369dc6a857a097b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EditEmployee), @"mvc.1.0.view", @"/Views/Employee/EditEmployee.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/_ViewImports.cshtml"
using NonGenericRepositoryPattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/_ViewImports.cshtml"
using NonGenericRepositoryPattern.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e34e8d652b76ab889f488369dc6a857a097b76", @"/Views/Employee/EditEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51b1e0de98501b00de42ed28730b4cd09ff47f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EditEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NonGenericRepositoryPattern.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
  
    ViewBag.Title = "EditEmployee";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Edit Employee</h4>\n        <hr />\n        ");
#nullable restore
#line 13 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
   Write(Html.HiddenFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 17 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
       Write(Html.LabelFor(model => model.Name, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 19 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 20 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 25 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
       Write(Html.LabelFor(model => model.Gender, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 27 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.EditorFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 28 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.ValidationMessageFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 33 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
       Write(Html.LabelFor(model => model.Salary, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 35 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.EditorFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 36 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.ValidationMessageFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 41 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
       Write(Html.LabelFor(model => model.Dept, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 43 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.EditorFor(model => model.Dept));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 44 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
           Write(Html.ValidationMessageFor(model => model.Dept));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 54 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 57 "/media/md-wahid/Projects And Others/Ubuntu/Home/Public/Projects/C#/Design-Pattern/Repository Pattern/Non-Generic Repository Pattern/NonGenericRepositoryPattern/Views/Employee/EditEmployee.cshtml"
Write(Html.ActionLink("Back to Employee List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NonGenericRepositoryPattern.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591