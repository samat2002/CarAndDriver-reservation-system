using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvc.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="กรุณาป้อนชื่อ")]
        [DisplayName("ชื่อ")]
        public string Name { get; set; }
        [DisplayName("คะเเนน")]
        [Range(0, 100, ErrorMessage ="คะเเนนต้องอยู่ช่วง 0-100 เท่านั้น")] 
        public int Score { get; set; }
    }
}
