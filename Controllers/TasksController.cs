﻿using lesson3.Bl;
using lesson3.Dl;
using lesson3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace lesson3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IService _service;
        public TasksController(IService service)
        {
            _service = service;
        }

        //get all tasks
        [HttpGet]
        public IEnumerable<Tasks> GetTasks()
        {
            return _service.GetAllTasks();
        }

        //create task
        [HttpPost]
        public Tasks CreateTask([FromBody] Tasks task)
        {
            return _service.createTask(task);
        }
        
        //update task
        [HttpPut]
        public Tasks UpdateTask([FromBody]Tasks task)
        {
            _service.UpdateTasks(task);
            return task;
        }

        //delete task
        [HttpDelete]  
        public IEnumerable<Tasks> Delete([FromBody] int id)
        {
            return _service.Delete(id);
        }

        //get task by id
        [HttpGet("{Id}")]
        public IEnumerable<Tasks> GetTasksByUserId(int Id)
        {
            return _service.GetTasksByuserId(Id);
        }
    }
}
