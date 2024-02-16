using Microsoft.AspNetCore.Mvc;
namespace SbuxApi.Controllers;

[ApiController, Route("balance")]
public class SbuxController : ControllerBase
{
	[HttpGet( "{steamId}/{token}" )]
	public IActionResult GetBalance( long steamId, string token )
	{
		return Ok($"get: {steamId} {token}");
	}

	[HttpPut( "{steamId}/{token}" )]
	public IActionResult UpsertBalance( long steamId, string token )
	{
		return Ok( $"upsert: {steamId} {token}" );
	}
}
