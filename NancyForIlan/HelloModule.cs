using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;

namespace NancyForIlan
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = _ => "Hello Ilan!";


            Get["/{entity}/{id?}"] = parameters =>
            {
                var entity = new MyEntity
                {
                    entity = parameters.entity,
                    id = parameters.id
                };
                var ent2 = this.Bind<MyEntity>();
                return Negotiate.WithStatusCode(HttpStatusCode.OK)
                    .WithModel(new []{parameters.entity, (int)parameters.id});
            };
        }
    }

    public class MyEntity
    {
        public string entity { get; set; }
        public int id { get; set; }
    }
}