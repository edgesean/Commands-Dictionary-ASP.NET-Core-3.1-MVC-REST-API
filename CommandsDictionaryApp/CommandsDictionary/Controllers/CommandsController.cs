using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsDictionary.Data;
using CommandsDictionary.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandsDictionary.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }

        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}
