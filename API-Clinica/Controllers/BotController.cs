using API_Clinica.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        [HttpGet]
        public object Get(Credentials_Request bot)
        {

            var Id = bot.Id;
            var Text = bot.Text;
            var Data = bot.Data;


            var Contact = bot.Contact;
            var uid = Contact.Uid;
            var type = Contact.Type;
            var Key = Contact.Key;
            var Name = Contact.Name;


            var Fields = Contact.Fields;
            var CPF = Fields.Cpf;
            var celular = Fields.Celular;

            // VOCES VAO COLOCAR OS TRATAMENTOS
            //SQL RECEBE ALGUMA VARIAVEL
            //FAZ UM WHERE COM A VARIAVEL
            //O QUE RETORNAR DESSE WHERE
            //VCS PODEM COLOCAR NA RESPONSE.

            var response = new Credentials_Response
            {
                Attachments = new Attachments
                {
                    Position = "AFTER",  //copiei pdf
                    Type = "D O C U M E N T",
                    Name = Name,
                    Url = "https/teste.com.br"

                },
                Type = "INFORMATION",
                Text = Text + "teste aonde vc pode escrever o que quiser",

            };

            var teste = response;
            return new JsonResult(teste);
        }

        // POST api/<BotController>
        [HttpPost]
        public object Post(Credentials_Request bot)
        {
            var Id = bot.Id;
            var Text = bot.Text;
            var Data = bot.Data;

            
            var Contact = bot.Contact;
            var uid = Contact.Uid;
            var type = Contact.Type;
            var Key = Contact.Key;
            var Name = Contact.Name;
            

            var Fields = Contact.Fields;
            var CPF = Fields.Cpf;
            var celular = Fields.Celular;

            // VOCES VAO COLOCAR OS TRATAMENTOS
            //SQL RECEBE ALGUMA VARIAVEL
            //FAZ UM WHERE COM A VARIAVEL
            //O QUE RETORNAR DESSE WHERE
            //VCS PODEM COLOCAR NA RESPONSE.

            var response = new Credentials_Response
            {
                Attachments = new Attachments
                {
                    Position = "AFTER",  //copiei pdf
                    Type = "D O C U M E N T",
                    Name = Name,
                    Url = "https/teste.com.br"

                },
                Type = "INFORMATION",
                Text = Text + "teste aonde vc pode escrever o que quiser",

            };

            var teste = response;
            return new JsonResult(teste);
        }



        //retorno json assim oh
        //[HttpPost("{Json}")]
        //public object PostReturnJson()
        //{
        //    var payload = new Credentials_Request
        //    {
        //        Contact = new Contact
        //        {
        //            Name = "Agent Name",
        //        },
        //        Id = 23
        //    };

        //    var teste = payload;
        //    return new JsonResult(teste);

        //}


    }
}
