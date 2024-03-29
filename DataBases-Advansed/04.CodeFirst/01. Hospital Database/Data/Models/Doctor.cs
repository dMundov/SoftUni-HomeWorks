﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _01.HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Visitations = new List<Visitation>();
        }

        public int DoctorId  { get; set; }

        
        public string Name { get; set; }
       
        public string Specialty { get; set; }

        public ICollection<Visitation> Visitations { get; set; }







    }
}
