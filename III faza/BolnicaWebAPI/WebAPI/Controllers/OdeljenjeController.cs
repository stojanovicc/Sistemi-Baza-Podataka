using Microsoft.AspNetCore.Mvc;
using BolnicaLibrary;
using BolnicaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OdeljenjeController : ControllerBase
{
    public OdeljenjeController()
    {
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpGet("PreuzmiSvaOdeljenja")]
    public async Task<ActionResult> VratiSvaOdeljenja()
    {
        var (isError, odeljenja, error) = await DataProvider.VratiSvaOdeljenjaAsync();

        if (isError)
        {
            return BadRequest(error);
        }

        return Ok(odeljenja);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost("KreirajOdeljenje/{specijalistaID}")]
    public async Task<ActionResult> KreirajOdeljenje([FromBody] OdeljenjeView odeljenje, int specijalistaID)
    {
        var (isError, sifra, error) = await DataProvider.SacuvajOdeljenjeBezSpecijalisteAsync(odeljenje);  

        if (isError)
        {
            return BadRequest(error);
        }

        var data = await DataProvider.PoveziOdeljenjeISpecijalistuAsync(sifra, specijalistaID);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return StatusCode(201, $"Upisano odeljenje, sa ID: {sifra}");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("IzmenaOdeljenja")]
    public async Task<ActionResult> IzmenaOdeljenja([FromBody] OdeljenjeView odeljenje)
    {
        var data = await DataProvider.IzmeniOdeljenjeAsync(odeljenje);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Upisano izmenjeno odeljenje, sa ID: {odeljenje.Sifra}");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpDelete("IzbrisiOdeljenje/{idOdeljenja}")]
    public async Task<ActionResult> IzbrisiOdeljenje(int idOdeljenja)
    {
        var data = await DataProvider.ObrisiOdeljenjeAsync(idOdeljenja);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Izbrisano odeljenje, sa ID: {idOdeljenja}");
    }

    //Veza N:M LEZI_NA
    [HttpPost]
    [Route("PoveziStacionarnogIOdeljenje/{matbr}/{sifra}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> LinkStacionarniToOdeljenje(int matbr, int sifra)
    {
        (bool isError1, var stacionarni, string? error1) = DataProvider.VratiStacionarni(matbr);
        (bool isError2, var odeljenje, string? error2) = await DataProvider.VratiOdeljenjeAsync(sifra);

        if (isError1 || isError2)
        {
            return BadRequest(error1 + Environment.NewLine + error2);
        }

        if (odeljenje == null || stacionarni == null)
        {
            return BadRequest("Nevalidno odeljenje ili stacionarni pacijent.");
        }

        var povezi = new LeziNaView
        {
            StacionarniLezi = stacionarni,
            LeziNaOdeljenju = odeljenje
        };

        var data = await DataProvider.SacuvajLeziNaAsync(povezi);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno povezan stacionarni pacijent sa odeljenjem na kom pacijent lezi: {data.Data}.");
    }

    //Veza N:M ODRZAVA_HIGIJENU_NA
    [HttpPost]
    [Route("PoveziHigijenicaraIOdeljenje/{matbr}/{sifra}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> LinkHigijenicarToOdeljenje(int matbr, int sifra)
    {
        (bool isError1, var nemedicinsko, string? error1) = DataProvider.VratiNemedicinsko(matbr);
        (bool isError2, var odeljenje, string? error2) = await  DataProvider.VratiOdeljenjeAsync(sifra);

        if (isError1 || isError2)
        {
            return BadRequest(error1 + Environment.NewLine + error2);
        }

        if (odeljenje == null || nemedicinsko == null)
        {
            return BadRequest("Nevalidno odeljenje ili higijenicar.");
        }

        var povezi = new OdrzavaHigijenuNaView
        {
            OdrzavaOdeljenje = odeljenje,
            HigijenicarOdrzava = nemedicinsko
        };

        var data = await DataProvider.SacuvajOdrzavaHigijenuNaAsync(povezi);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno povezan higijenicar sa odeljenjem koje odrzava: {data.Data}.");
    }
}
