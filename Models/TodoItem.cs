using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTraining.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        protected string name;


        public string Name
        {

            get => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            
            set => name = value;
        }

        [Required]
        [Column]
        public bool IsComplete { get; set; }





    }
}
