using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdminService.Models;

namespace AdminService.Dtos {
    public class ScheduleCreateDto {
        [Required]
        public string Title { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
    }
}