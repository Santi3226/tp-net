using Application.Services;
using Domain.Model;
using DTOs;

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




app.MapGet("/pacientes/{id}", (int id) =>
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
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/pacientes", () =>
{
    PacienteService pacienteService = new PacienteService();

    PacienteDTO dtos = pacienteService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllPacientes")
.Produces<List<PacienteDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/pacientes", (PacienteDTO dto) =>
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
        PacienteService clienteService = new PacienteService();

        var found = clienteService.Update(dto);

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


app.Run();

