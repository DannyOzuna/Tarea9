// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea9.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Tarea9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Tarea9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Tarea9.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using Tarea9.Data.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\danny\Desktop\Tarea9\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Tarea9\Pages\Registrar.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrar")]
    public partial class Registrar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\danny\Desktop\Tarea9\Pages\Registrar.razor"
       
    Vacunados oVacunados = new Vacunados();
    List<Provincias> lsProvincias = new List<Provincias>();
    List<tipoDeSangre> lsSangre = new List<tipoDeSangre>();

    private string Mensage {get; set; } = "";

    protected async override Task OnInitializedAsync()
    {
        lsProvincias =  await RepoVacunados.GetProvincias();
        lsSangre = await RepoVacunados.GetTipoDeSangres();
    }

    private async Task GuardarDatos(){

        //Para obtener la latitud y longitud mediante la ip
        var datos = http.GetFromJsonAsync<Localicacion>("http://ip-api.com/json/");
        var ip = datos.Result;

        oVacunados.latitud = ip.lat.ToString();
        oVacunados.longitud = ip.lon.ToString();

        var crear =  await RepoVacunados.Add(oVacunados);


        if(crear != null){
            var rs = await js.InvokeAsync<object>("msjAlert", "Registrado Correctamente", "success");
            EnviarMensaje();
        }else{
            var rs = await js.InvokeAsync<object>("msjValidation", "Existe", "Esta solicitud está creada!", "error");
        }
    }


    public void EnviarMensaje()
    {
        try
        {
            using(MailMessage mail = new MailMessage())
            {

             mail.From =  new MailAddress("ventanilla781444@gmail.com");
                mail.To.Add(oVacunados.email);
                mail.Subject = "Cita Para la Confirmacion de la Vacuna";
                mail.Body ="<td style=background-color: #ecf0f1>"+
                        "<div style=color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif>"+
                        "<h2 style=color: #e67e22; margin: 0 0 7px>Copia del formulario!</h2>"+
                        $"<li> Nombre:'{oVacunados.nombre}'</li>" +
                        $"<li>Apellido: '{oVacunados.apellido}' </li>" +
                        $"<li>Telefono: '{oVacunados.telefono}'</li>" +
                        $"<li>Cedula: '{oVacunados.cedula}'</li>" +
                        $"<li>Provincia: '{oVacunados.provincia}'</li>" +
                        $"<li>Direccion: '{oVacunados.direccion}'</li>" +
                        $"<li>Justificacion: '{oVacunados.justificacion}'</li>" +
                        $"<li>Te ha dado covid: '{oVacunados.covid}'</li>" +
                        $"<li>Tipo de Sangra: '{oVacunados.tipo_sangre}'</li>" ;
                        
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com",587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("ventanilla781444@gmail.com", "HOLAMUNDO");
                    smtp.EnableSsl =true;
                    smtp.Send(mail);
                    var rs = js.InvokeAsync<object>("msjAlert", "Correo Enviado!...", "success");
                    NavigationManager.NavigateTo("/");
                }
            }

         }
        catch(Exception x){

            Mensage = x.Message;

        }



     }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepoVacunados RepoVacunados { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
