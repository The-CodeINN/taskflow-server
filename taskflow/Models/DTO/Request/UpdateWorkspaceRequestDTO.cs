﻿using System.ComponentModel.DataAnnotations;

namespace taskflow.Models.DTO.Request
{
    public class UpdateWorkspaceRequestDTO
    {
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(255, ErrorMessage = "Only Max of 255 characters is allowed")]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(500, ErrorMessage = "Only Max of 500 characters is allowed")]
        public string Description { get; set; }
    }
}

