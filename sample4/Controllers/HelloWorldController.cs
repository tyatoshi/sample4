using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sample4.Controllers
{
    public class HelloWorldController : Controller
    {
        /*
        /[Controller]/[ActionName]/[Parameters]
        Controller⇨ActionNameで見ていく
        actionが設定されていない場合にはindexが指定されたものとなる。
        */
        // GET: HelloWorld
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return name + "さんは" + numTimes + "歳です";
        }
    }
}