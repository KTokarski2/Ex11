#pragma checksum "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e012555d3b66db78434fdceca3c1a2d1181b5bd"
// <auto-generated/>
#pragma warning disable 1591
namespace cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using cw11.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ktoka\Desktop\cw11\cw11\_Imports.razor"
using cw11.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students/{ID:int}")]
    public partial class StudentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>StudentDetails</h3>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", 
#nullable restore
#line 7 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
               ID

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", 
#nullable restore
#line 8 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
               student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 9 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
           student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 10 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
                     student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "<br>\r\n<br>");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 11 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
                     student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<br>\r\n<br>");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 12 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
                     student.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<br>\r\n<br>");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "value", 
#nullable restore
#line 13 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
                     student.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\ktoka\Desktop\cw11\cw11\Pages\StudentDetails.razor"
       
    [Parameter]
    public int ID { get; set; }

    Student student;

    protected override void OnInitialized()
    {
        student = StudentService.GetStudent(ID);
    }

    [Parameter]
    public string FirstName { get; set; }

    [Parameter]
    public string LastName { get; set; }

    [Parameter]
    public DateTime BirthDate { get; set; }

    [Parameter]
    public string Studies { get; set; }

    [Parameter]
    public string Avatar { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
