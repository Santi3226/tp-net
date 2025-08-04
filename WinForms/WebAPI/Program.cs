using Application.Services;
using Domain.Model;
using DTOs;
using Microsoft.AspNetCore.OpenApi;

var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build(); 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();   
    app.UseHttpLogging();
}

app.UseHttpsRedirection();
 
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

app.Run();

