using System.Collections.Generic;
using AdminService.Data;
using AdminService.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase {
        private readonly IScheduleRepo _repository;
        private readonly IMapper _mapper;

        public SchedulesController (IScheduleRepo repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ScheduleReadDto>> GetSchedules() {
            var schedulesItem = _repository.GetAllSchedules();

            return Ok(_mapper.Map<IEnumerable<ScheduleReadDto>>(schedulesItem));
        }
    }
}