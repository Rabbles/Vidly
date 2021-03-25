using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomFilmViewModel
    {
        public Film Film { get; set; }

        public List<Customer> Customers { get; set; }
    }
}