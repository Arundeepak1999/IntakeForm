﻿using System.ComponentModel.DataAnnotations;

namespace IntakeForm.Models
{
    public class ProblemsAndSugeriesInfo
    {
        
        public string Problems { get; set; }
        
        public DateTime ProblemsOnsetDate { get; set; }
        
        public string Surgeries { get; set; }
        
        public string SurgeriesOnsetDate { get; set; }
    }
}
