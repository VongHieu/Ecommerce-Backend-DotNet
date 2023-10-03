﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shopecommerce.Application.Commands.PromotionCommand.CreatePromotion;
using System.Net;

namespace shopecommerce.API.Controllers
{
    [ApiController]
    [Route("v1/promotion")]
    public class PromotionController : BaseController
    {
        public PromotionController(IMediator mediator, IAuthorizationService authorizationService) : base(mediator, authorizationService)
        {
        }

        [HttpPost("create")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreatePromotionAsync([FromBody] CreatePromotionCommand command)
        {
            var resp = await _mediator.Send(command);
            return Ok(resp);
        }

        [HttpPut("update")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdatePromotionAsync([FromQuery] string id, [FromBody] CreatePromotionCommand command)
        {
            command.SetId(id);
            var resp = await _mediator.Send(command);

            return Ok(resp);
        }
    }
}
