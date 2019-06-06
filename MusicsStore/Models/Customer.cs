using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicsStore.Models
{
    public class Customer
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public int Age { get; set; }
        [Display(Name = "Favorite Genre")]
        public string FavGenre { get; set; }
        [Display(Name = "Favorite Song")]
        public string FavSong { get; set; }
        [Display(Name = "Photo")]
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //return $nameOf
        //}
    }

}
