using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace WebApiTraining.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        private string _name;


        public string Name
        {

            get => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_name);

            set => _name = value;
        }

        [Required]
        public bool IsComplete { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
