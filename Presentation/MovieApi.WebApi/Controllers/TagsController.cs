﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagsList()
        {
            var values = await _mediator.Send(new GetTagQuery());
            return Ok(values);
        }

        [HttpGet("GetTag")]
        public async Task<IActionResult> GetTag(int TagID)
        {
            var values = await _mediator.Send(new GetTagByIdQuery(TagID));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket Ekleme İşlemi Başarılı.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTag(int TagID)
        {
            await _mediator.Send(new RemoveTagCommand(TagID));
            return Ok("Etiket Silme İşlemi Başarılı.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket Güncelleme İşlemi Başarılı.");
        }
    }
}