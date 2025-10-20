using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using System.Text;
using DTOs;
using Application.Services;
using Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

// Add Entity Framework Context
builder.Services.AddDbContext<TPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Server=(localdb)\\mssqllocaldb;Database=TPILaboratorio;Trusted_Connection=True;MultipleActiveResultSets=true")));

/*
// Add Dependency Injection
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();
*/
// Add JWT Authentication
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"];
var issuer = jwtSettings["Issuer"];
var audience = jwtSettings["Audience"];

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
{
options.TokenValidationParameters = new TokenValidationParameters
{
ValidateIssuer = true,
ValidIssuer = issuer,
ValidateAudience = true,
ValidAudience = audience,
ValidateLifetime = true,
ValidateIssuerSigningKey = true,
IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!)),
ClockSkew = TimeSpan.Zero
};
});

// Add Authorization Policies
builder.Services.AddAuthorization(options =>
{
    // Políticas para CentroAtencion
    options.AddPolicy("CentroAtencion", policy => policy.RequireClaim("permission", "CentroAtencion"));
    options.AddPolicy("CentroAtencionAgregar", policy => policy.RequireClaim("permission", "CentroAtencion.agregar"));
    options.AddPolicy("CentroAtencionActualizar", policy => policy.RequireClaim("permission", "CentroAtencion.actualizar"));
    options.AddPolicy("CentroAtencionEliminar", policy => policy.RequireClaim("permission", "CentroAtencion.eliminar"));

    // Políticas para Localidad
    options.AddPolicy("Localidad", policy => policy.RequireClaim("permission", "Localidad"));
    options.AddPolicy("LocalidadAgregar", policy => policy.RequireClaim("permission", "Localidad.agregar"));
    options.AddPolicy("LocalidadActualizar", policy => policy.RequireClaim("permission", "Localidad.actualizar"));
    options.AddPolicy("LocalidadEliminar", policy => policy.RequireClaim("permission", "Localidad.eliminar"));

    // Políticas para Paciente
    options.AddPolicy("Paciente", policy => policy.RequireClaim("permission", "Paciente"));
    options.AddPolicy("PacienteAgregar", policy => policy.RequireClaim("permission", "Paciente.agregar"));
    options.AddPolicy("PacienteActualizar", policy => policy.RequireClaim("permission", "Paciente.actualizar"));
    options.AddPolicy("PacienteEliminar", policy => policy.RequireClaim("permission", "Paciente.eliminar"));

    // Políticas para PlantillaAnalisis
    options.AddPolicy("PlantillaAnalisis", policy => policy.RequireClaim("permission", "PlantillaAnalisis"));
    options.AddPolicy("PlantillaAnalisisAgregar", policy => policy.RequireClaim("permission", "PlantillaAnalisis.agregar"));
    options.AddPolicy("PlantillaAnalisisActualizar", policy => policy.RequireClaim("permission", "PlantillaAnalisis.actualizar"));
    options.AddPolicy("PlantillaAnalisisEliminar", policy => policy.RequireClaim("permission", "PlantillaAnalisis.eliminar"));

    // Políticas para TipoAnalisis
    options.AddPolicy("TipoAnalisis", policy => policy.RequireClaim("permission", "TipoAnalisis"));
    options.AddPolicy("TipoAnalisisAgregar", policy => policy.RequireClaim("permission", "TipoAnalisis.agregar"));
    options.AddPolicy("TipoAnalisisActualizar", policy => policy.RequireClaim("permission", "TipoAnalisis.actualizar"));
    options.AddPolicy("TipoAnalisisEliminar", policy => policy.RequireClaim("permission", "TipoAnalisis.eliminar"));

    // Políticas para Turno
    options.AddPolicy("Turno", policy => policy.RequireClaim("permission", "Turno"));
    options.AddPolicy("TurnoAgregar", policy => policy.RequireClaim("permission", "Turno.agregar"));
    options.AddPolicy("TurnoActualizar", policy => policy.RequireClaim("permission", "Turno.actualizar"));
    options.AddPolicy("TurnoEliminar", policy => policy.RequireClaim("permission", "Turno.eliminar"));
    // Fallback: Requerir autenticación para endpoints no especificados
    //options.FallbackPolicy = options.DefaultPolicy;
    options.FallbackPolicy = null;
});

// Add CORS for Blazor WebAssembly + React Native
builder.Services.AddCors(options =>
{
options.AddPolicy("AllowBlazorWasm",
    policy =>
{
policy.AllowAnyOrigin() // TODO: En producción especificar orígenes exactos por seguridad
      .AllowAnyHeader()
      .AllowAnyMethod();
});
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.MapGet("/", () => Results.Redirect("/swagger/index.html"));
app.UseSwaggerUI();
app.UseHttpLogging();
}

app.UseHttpsRedirection();

// Use CORS
app.UseCors("AllowBlazorWasm");

/*
// Use Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();
*/
app.MapGet("/Pacientes/{id}", (int id) =>
{
    PacienteService pacienteService = new PacienteService();

    PacienteDTO dto = pacienteService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetPaciente")
.Produces<PacienteDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound).
WithOpenApi();

app.MapGet("/Pacientes", () =>
{
    PacienteService pacienteService = new PacienteService();

    var dtos = pacienteService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllPacientes")
.Produces<List<PacienteDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/Pacientes", (PacienteDTO dto) =>
{
    try
    {
        PacienteService pacienteService = new PacienteService();

        PacienteDTO pacienteDTO = pacienteService.Add(dto);

        return Results.Created($"/pacientes/{pacienteDTO.Id}", pacienteDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddPaciente")
.Produces<PacienteDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/pacientes", (PacienteDTO dto) =>
{
    try
    {
        PacienteService pacienteService = new PacienteService();

        var found = pacienteService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdatePaciente")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/pacientes/{id}", (int id) =>
{
    PacienteService pacienteService = new PacienteService();

    var deleted = pacienteService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeletePaciente")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

/*
 * app.MapGet("/clientes/criteria", (string texto) =>
{
    try
    {
        ClienteService clienteService = new ClienteService();
        var criteria = new ClienteCriteriaDTO { Texto = texto };
        var clientes = clienteService.GetByCriteria(criteria);
        return Results.Ok(clientes);
    }
    catch (Exception ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("GetClientesByCriteria")
.WithOpenApi();
*/

app.MapGet("/centrosAtencion/{id}", (int id) =>
{
    CentroAtencionService centroAtencionService = new CentroAtencionService();

    CentroAtencionDTO dto = centroAtencionService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetCentroAtencion")
.Produces<CentroAtencionDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound).
WithOpenApi();

app.MapGet("/centrosAtencion", () =>
{
    CentroAtencionService centroAtencionService = new CentroAtencionService();

    var dtos = centroAtencionService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllCentrosAtencion")
.Produces<List<CentroAtencionDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/centrosAtencion", (CentroAtencionDTO dto) =>
{
    try
    {
        CentroAtencionService centroAtencionService = new CentroAtencionService();

        CentroAtencionDTO centroAtencionDTO = centroAtencionService.Add(dto);

        return Results.Created($"/centrosAtencion/{centroAtencionDTO.Id}", centroAtencionDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddCentroAtencion")
.Produces<CentroAtencionDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/centrosAtencion", (CentroAtencionDTO dto) =>
{
    try
    {
        CentroAtencionService centroAtencionService = new CentroAtencionService();

        var found = centroAtencionService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateCentroAtencion")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/centrosAtencion/{id}", (int id) =>
{
    CentroAtencionService centroAtencionService = new CentroAtencionService();

    var deleted = centroAtencionService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteCentroAtencion")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

// ------------

app.MapGet("/turnos/{id}", (int id) =>
{
    TurnoService turnoService = new TurnoService();

    TurnoDTO dto = turnoService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetTurno")
.Produces<TurnoDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound).
WithOpenApi();

app.MapGet("/turnos", () =>
{
    TurnoService turnoService = new TurnoService();

    var dtos = turnoService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllTurnos")
.Produces<List<TurnoDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/turnos", (TurnoDTO dto) =>
{
    try
    {
        TurnoService turnoService = new TurnoService();

        TurnoDTO turnoDTO = turnoService.Add(dto);

        return Results.Created($"/turnos/{turnoDTO.Id}", turnoDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddTurnos")
.Produces<TurnoDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/turnos", (TurnoDTO dto) =>
{
    try
    {
        TurnoService turnoService = new TurnoService();

        var found = turnoService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateTurno")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/turnos/{id}", (int id) =>
{
    TurnoService turnoService = new TurnoService();

    var deleted = turnoService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteTurno")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

// ------------

app.MapGet("/tiposAnalisis/{id}", (int id) =>
{
    TipoAnalisisService tipoAnalisisService = new TipoAnalisisService();

    TipoAnalisisDTO dto = tipoAnalisisService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetTipoAnalisis")
.Produces<TipoAnalisisDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound).
WithOpenApi();

app.MapGet("/tiposAnalisis", () =>
{
    TipoAnalisisService tipoAnalisisService = new TipoAnalisisService();

    var dtos = tipoAnalisisService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllTiposAnalisis")
.Produces<List<TipoAnalisisDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/tiposAnalisis", (TipoAnalisisDTO dto) =>
{
    try
    {
        TipoAnalisisService tipoAnalisisService = new TipoAnalisisService();

        TipoAnalisisDTO tipoAnalisisDTO = tipoAnalisisService.Add(dto);

        return Results.Created($"/tiposAnalisis/{tipoAnalisisDTO.Id}", tipoAnalisisDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddTipoAnalisis")
.Produces<TipoAnalisisDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/tiposAnalisis", (TipoAnalisisDTO dto) =>
{
    try
    {
        TipoAnalisisService tipoAnalisisService = new TipoAnalisisService();

        var found = tipoAnalisisService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateTipoAnalisis")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/tiposAnalisis/{id}", (int id) =>
{
    TipoAnalisisService tipoAnalisisService = new TipoAnalisisService();

    var deleted = tipoAnalisisService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteTipoAnalisis")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

// ------------

app.MapGet("/localidades/{id}", (int id) =>
{
    LocalidadService localidadService = new LocalidadService();

    LocalidadDTO dto = localidadService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetLocalidad")
.Produces<LocalidadDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound).
WithOpenApi();

app.MapGet("/localidades", () =>
{
    LocalidadService localidadService = new LocalidadService();

    var dtos = localidadService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllLocalidades")
.Produces<List<LocalidadDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/localidades", (LocalidadDTO dto) =>
{
    try
    {
        LocalidadService localidadService = new LocalidadService();

        LocalidadDTO localidadDTO = localidadService.Add(dto);

        return Results.Created($"/localidades/{localidadDTO.Id}", localidadDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddLocalidad")
.Produces<LocalidadDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/localidades", (LocalidadDTO dto) =>
{
    try
    {
        LocalidadService localidadService = new LocalidadService();

        var found = localidadService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateLocalidad")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/localidades/{id}", (int id) =>
{
    LocalidadService localidadService = new LocalidadService();

    var deleted = localidadService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteLocalidad")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

// ------------

app.MapGet("/plantillasAnalisis/{id}", (int id) =>
{
    PlantillaAnalisisService plantillaAnalisisService = new PlantillaAnalisisService();

    PlantillaAnalisisDTO dto = plantillaAnalisisService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetPlantillaAnalisis")
.Produces<PlantillaAnalisisDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound).
WithOpenApi();

app.MapGet("/plantillasAnalisis", () =>
{
    PlantillaAnalisisService plantillaAnalisisService = new PlantillaAnalisisService();

    var dtos = plantillaAnalisisService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllPlantillas")
.Produces<List<PlantillaAnalisisDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/plantillasAnalisis", (PlantillaAnalisisDTO dto) =>
{
    try
    {
        PlantillaAnalisisService plantillaAnalisisService = new PlantillaAnalisisService();

        PlantillaAnalisisDTO plantillaAnalisisDTO = plantillaAnalisisService.Add(dto);

        return Results.Created($"/plantillasAnalisis/{plantillaAnalisisDTO.Id}", plantillaAnalisisDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddPlantillaAnalisis")
.Produces<PlantillaAnalisisDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/plantillasAnalisis", (PlantillaAnalisisDTO dto) =>
{
    try
    {
        PlantillaAnalisisService plantillaAnalisisService = new PlantillaAnalisisService();

        var found = plantillaAnalisisService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdatePlantillaAnalisis")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/plantillasAnalisis/{id}", (int id) =>
{
    PlantillaAnalisisService plantillaAnalisisService = new PlantillaAnalisisService();

    var deleted = plantillaAnalisisService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeletePlantillaAnalisis")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();
app.Run();

