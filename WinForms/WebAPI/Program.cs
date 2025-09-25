using Application.Services;
using Domain.Model;
using DTOs;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorWasm",
        policy =>
        {
            policy.WithOrigins("https://localhost:7170", "http://localhost:5076")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build(); 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();   
    app.UseHttpLogging();
}

app.UseHttpsRedirection();
app.UseRewriter(new RewriteOptions()
    .AddRedirect("^$", "/swagger/index.html") // Redirect root to home/index
);

// Use CORS
app.UseCors("AllowBlazorWasm");

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

app.Run();

