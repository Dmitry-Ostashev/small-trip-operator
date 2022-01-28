using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdminService.Data;
using AdminService.Dtos;
using AdminService.Models;
using AdminService.SyncDataServices.Http;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase {
        private readonly IScheduleRepo _repository;
        private readonly IMapper _mapper;

        private readonly ICommandDataClient _commandDataClient;

        public SchedulesController(
            IScheduleRepo repository,
            IMapper mapper,
            ICommandDataClient commandDataClient) {
            _repository = repository;
            _mapper = mapper;
            _commandDataClient = commandDataClient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ScheduleReadDto>> GetSchedules() {
            var schedulesItem = _repository.GetAllSchedules();

            return Ok(_mapper.Map<IEnumerable<ScheduleReadDto>>(schedulesItem));
        }

        [HttpGet("{id}", Name = "GetScheduleById")]
        public ActionResult<ScheduleReadDto> GetScheduleById(int id) {
            var scheduleItem = _repository.GetScheduleById(id);

            if (scheduleItem != null)
                return Ok(_mapper.Map<ScheduleReadDto>(scheduleItem));

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<ScheduleReadDto>> CreateSchedule(ScheduleCreateDto scheduleCreateDto) {
            var scheduleModel = _mapper.Map<Schedule>(scheduleCreateDto);
            _repository.CreateSchedule(scheduleModel);
            _repository.SaveChanges();

            var scheduleReadDto = _mapper.Map<ScheduleReadDto>(scheduleModel);

            try {
                await _commandDataClient.SendScheduleToCommand(scheduleReadDto);
            }
            catch(Exception ex) {
                Console.WriteLine($"--> Could not send synchronously: {ex.Message}");
            }

            return CreatedAtRoute(nameof(GetScheduleById), new { Id = scheduleReadDto.Id }, scheduleReadDto);
        }
    }
}