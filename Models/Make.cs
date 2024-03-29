using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Extensions.DependencyInjection;


namespace Vega.Models
{
    public class Make
    {
        public int Id{get;set;}
        public string Name{get; set;}
        public ICollection<Model> Models{get; set;}

        public Make(){
            Models = new Collection<Model>();
        }
    }
}