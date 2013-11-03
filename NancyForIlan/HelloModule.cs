using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyForIlan
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = _ => "Hello Ilan!";

            Get["/{entity}/{id}"] = parameters =>
                Negotiate.WithStatusCode(HttpStatusCode.OK)
                    .WithModel(new[] {parameters.entity, parameters.id});
        }
    }
}