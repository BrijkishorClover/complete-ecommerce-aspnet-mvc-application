using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class CinemaModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Cinema logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationship
        public List<MovieModel> Movies { get; set; }
    }
}
