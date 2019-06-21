using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeltExam.Models
{
    public class Event
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        [DataType(DataType.Time)]
        public TimeSpan Time {get;set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}
        [Required]
        public int Duration {get;set;}
        public string DurationType {get;set;}
        [Required]
        [MaxLength(255, ErrorMessage="Conent Cannot be longer than 255 characters!")]
        public string Description {get;set;}
        public List<Participant> Participants {get;set;}
        public int UserID {get; set;}
        public User Creator {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}