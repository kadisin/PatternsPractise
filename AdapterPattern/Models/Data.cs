using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    public class Data
    {
        public string Xml => @"<?xml version='1.0'?>
    <SquidGame>
      <Genre>Thriller</Genre>
      <Rating Type='Imdb'>8.1</Rating>
      <Stars>Lee Jung-jae</Stars>
      <Stars>Park Hae-soo</Stars>
      <Budget />
    </SquidGame>";
    }
}
