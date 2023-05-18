using SafeSpeak.API.Models;
using SafeSpeak.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeSpeak.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversationsController : ControllerBase
    {
        private readonly IConversationService _conversationService;

        public ConversationsController(IConversationService conversationService)
        {
            _conversationService = conversationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conversation>>> GetAllConversations()
        {
            try
            {
                var conversations = await _conversationService.GetAllConversationsAsync();
                return Ok(conversations);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Conversation>> GetConversationById(int id)
        {
            try
            {
                var conversation = await _conversationService.GetConversationByIdAsync(id);
                if (conversation == null)
                {
                    return NotFound();
                }
                return Ok(conversation);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddConversation(Conversation conversation)
        {
            try
            {
                await _conversationService.AddConversationAsync(conversation);
                return CreatedAtAction(nameof(GetConversationById), new { id = conversation.Id }, conversation);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateConversation(int id, Conversation conversation)
        {
            try
            {
                if (id != conversation.Id)
                {
                    return BadRequest();
                }
                await _conversationService.UpdateConversationAsync(conversation);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConversation(int id)
        {
            try
            {
                var conversation = await _conversationService.GetConversationByIdAsync(id);
                if (conversation == null)
                {
                    return NotFound();
                }
                await _conversationService.DeleteConversationAsync(conversation);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

