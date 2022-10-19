using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("user")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }
    
        public static bool verificaLoginSenha(string Login, string Senha, Controller controller)
        {
        
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                verificaSeUsuarioAdminExiste(bc);

                Senha = Criptografo.TextoCriptografado(Senha);

                IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where(u => u.Login == Login && u.Senha == Senha);
                List<Usuario>ListaUsuarioEncontrado = UsuarioEncontrado.ToList();
        
                if(ListaUsuarioEncontrado.Count==0)
                {
                    return false;
                }
                else
                {
                controller.HttpContext.Session.SetString("Login",ListaUsuarioEncontrado[0].Login);
                controller.HttpContext.Session.SetString("Nome",ListaUsuarioEncontrado[0].Nome);
                controller.HttpContext.Session.SetInt32("Tipo",ListaUsuarioEncontrado[0].Tipo);
                return true;
                }
            }
        }
        
        public static void verificaSeUsuarioAdminExiste (BibliotecaContext bc)
        {
            IQueryable<Usuario> userEncontrado = bc.Usuarios.Where(u=>u.Login=="admin");
            if(userEncontrado.ToList().Count==0)
            {
            Usuario admin = new Usuario();
            admin.Login = "admin";
            admin.Senha = Criptografo.TextoCriptografado("123");
            admin.Tipo = Usuario.ADMIN;
            admin.Nome = "Administrador";

            bc.Usuarios.Add(admin);
            bc.SaveChanges();
                }
            }
            
            public static void verificaSeUsuarioEAdmin(Controller controller)
            {
                if(!(controller.HttpContext.Session.GetInt32("Tipo")== Usuario.ADMIN))
                {
                    controller.Request.HttpContext.Response.Redirect("/Usuarios/NeedAdmin");
                }
            }
            
        }
}